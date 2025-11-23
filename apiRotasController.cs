using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoSGHSS
{
    public static class apiRotasController
    {
        private static readonly string baseUrl = "http://127.0.0.1:5000";

        public static string CadastroUsuario => $"{baseUrl}/Usuario";
        
    }
}
