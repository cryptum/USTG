using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class DadosPessoal
    {
        public ReservistaM Reservista_IdReservista { get; set; }
        public string NomeCompleto { get; set; }
        public string DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }

        public DadosPessoal()
        {
        }

        public DadosPessoal(ReservistaM reservista_IdReservista, string nomeCompleto, string dataNascimento, string nomeMae, string nomePai)
        {
            Reservista_IdReservista = reservista_IdReservista;
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
            NomeMae = nomeMae;
            NomePai = nomePai;
        }
    }
}
