using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class DadosDocumento
    {
        public ReservistaM Reservista_IdReservista { get; set; }
        public string RA { get; set; }
        public string Identidade { get; set; }
        public string CPF { get; set; }
        public string TituloEleitoral { get; set; }

        public DadosDocumento()
        {
        }

        public DadosDocumento(ReservistaM reservista_IdReservista, string rA, string identidade, string cPF, string tituloEleitoral)
        {
            Reservista_IdReservista = reservista_IdReservista;
            RA = rA;
            Identidade = identidade;
            CPF = cPF;
            TituloEleitoral = tituloEleitoral;
        }
    }
}
