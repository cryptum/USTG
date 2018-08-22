using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class DadosDomicilio
    {
        public ReservistaM Reservista_IdReservista { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string CidadeNatal { get; set; }

        public DadosDomicilio()
        {
        }

        public DadosDomicilio(ReservistaM reservista_IdReservista, string endereco, string bairro, string cidadeNatal)
        {
            Reservista_IdReservista = reservista_IdReservista;
            Endereco = endereco;
            Bairro = bairro;
            CidadeNatal = cidadeNatal;
        }
    }
}
