using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class ServidorM
    {
        public int IdServidor { get; set; }
        public string NomeCompleto { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public ServidorM()
        {
        }

        public ServidorM(int idServidor, string nomeCompleto, string login, string senha)
        {
            IdServidor = idServidor;
            NomeCompleto = nomeCompleto;
            Login = login;
            Senha = senha;
        }

    }
}
