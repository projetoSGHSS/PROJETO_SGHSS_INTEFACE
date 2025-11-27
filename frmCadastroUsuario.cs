using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoSGHSS
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private async void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            await CarregarDados();
        }

        private async Task CarregarDados()
        {
            string apiUrl = apiRotasController.CadastroUsuario;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<CadastroUsuarioModel>>(jsonString);

                        dgvCadastroUsuario.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1. Validações simples de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtEmailUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenhaHashUsuario.Text) ||
                string.IsNullOrWhiteSpace(cbTipo.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Campos faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Monta o objeto que será enviado para a API
            //Os nomes devem estar extamente iguais na API
            var novoUsuario = new
            {
                nome = txtNomeUsuario.Text.Trim(),
                email = txtEmailUsuario.Text,
                senhaHash = txtSenhaHashUsuario.Text.Trim(),
                tipo = cbTipo.Text

            };

            string apiPostUrl = apiRotasController.CadastroUsuario;
            string jsonBody = JsonConvert.SerializeObject(novoUsuario);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    using (var content = new StringContent(jsonBody, Encoding.UTF8, "application/json"))
                    {
                        // ===== CHAMADA POST =====
                        HttpResponseMessage response = await client.PostAsync(apiPostUrl, content);

                        if (response.StatusCode == HttpStatusCode.Created || response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Usuário criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();          // opcional: limpa as TextBox
                            await CarregarDados();   // recarrega o DataGridView
                        }
                        else
                        {
                            string detalhe = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Erro ao salvar: {response.StatusCode}\n{detalhe}",
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (HttpRequestException hre)
                {
                    MessageBox.Show($"Falha de comunicação com a API:\n{hre.Message}",
                                    "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro inesperado:\n{ex.Message}",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            // 1) Garantir que temos um ID
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de editar.", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Monta objeto com os campos (use os nomes esperados pela API)
            var usuarioAtualizado = new
            {
                nome = txtNomeUsuario.Text.Trim(),
                email = txtEmailUsuario.Text,
                senhaHash = txtSenhaHashUsuario.Text.Trim(),
                tipo = cbTipo.Text

            };

            // 3) Validação mínima (exemplo)
            if (string.IsNullOrWhiteSpace(usuarioAtualizado.nome) ||
                string.IsNullOrWhiteSpace(usuarioAtualizado.email) ||
                string.IsNullOrWhiteSpace(usuarioAtualizado.senhaHash) ||
                string.IsNullOrWhiteSpace(usuarioAtualizado.tipo))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.", "Campos faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4) Confirmação opcional
            var respConf = MessageBox.Show("Confirma a alteração deste usuário?", "Confirmar edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respConf != DialogResult.Yes) return;

            // 5) Envia PUT para /CadastroUsuario/<id>
            string apiPutUrl = $"{apiRotasController.CadastroUsuario}/{_idSelecionado}";
            string jsonBody = JsonConvert.SerializeObject(usuarioAtualizado);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage resposta = await client.PutAsync(apiPutUrl, content);

            if (resposta.IsSuccessStatusCode)      // 200 ou 204
            {
                MessageBox.Show("Registro atualizado com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6) Limpa seleção e recarrega grade
                _idSelecionado = null;
                LimparCampos();
                await CarregarDados();
            }
            else
            {
                string detalhe = await resposta.Content.ReadAsStringAsync();
                MessageBox.Show($"Erro ao atualizar: {resposta.StatusCode}\n{detalhe}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnApagar_Click(object sender, EventArgs e)
        {
            // 1) Pegar o ID do usuário que será excluído
            if (dgvCadastroUsuario.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário na grade.");
                return;
            }

            int idUsuario = (int)dgvCadastroUsuario.CurrentRow.Cells["id"].Value;

            // 2) Confirmar com o usuário
            var confirmar = MessageBox.Show($"Deseja realmente excluir o usuário {idUsuario}?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            // 3) Montar URL:  http://.../CadastroUsuario/<id>
            string apiDeleteUrl = $"{apiRotasController.CadastroUsuario}/{idUsuario}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // ===== CHAMADA DELETE =====
                    HttpResponseMessage response = await client.DeleteAsync(apiDeleteUrl);

                    if (response.StatusCode == HttpStatusCode.NoContent)        // 204
                    {
                        MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                        // 4) Recarregar a grade chamando seu GET
                        await CarregarDados();
                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)    // 404
                    {
                        MessageBox.Show("Usuário não encontrado.", "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string detalhe = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao excluir: {response.StatusCode}\n{detalhe}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException hre)
                {
                    MessageBox.Show($"Falha de comunicação com a API:\n{hre.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro inesperado:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimparCampos()
        {
            txtNomeUsuario.Clear();
            txtEmailUsuario.Clear();
            txtSenhaHashUsuario.Clear();
            cbTipo.SelectedIndex = 0;
            txtNomeUsuario.Focus();
        }

        //para selecionar a linha na dgv, ao clicar nela
        private int? _idSelecionado = null;

        private void dgvCadastroUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow linha = dgvCadastroUsuario.Rows[e.RowIndex];

            _idSelecionado = (int)linha.Cells["id"].Value;
            txtNomeUsuario.Text = linha.Cells["nome"].Value?.ToString();
            txtEmailUsuario.Text = linha.Cells["email"].Value?.ToString();
            txtSenhaHashUsuario.Text = linha.Cells["senhaHash"].Value?.ToString();
            cbTipo.Text = linha.Cells["tipo"].Value?.ToString();

        }
    }
}
