using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoSGHSS
{
    public class CadastroUsuarioModel
    {
        public int id { get; set; }
        public string nome { get; set; } 
        public string email { get; set; }
        public string senhaHash { get; set; }
        public string tipo { get; set; }
    }
}
