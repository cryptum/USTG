using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class TempoDeServico
    {
        public ReservistaM Reservista_IdReservista { get; set; }
        public double HoraExtra { get; set; }
        public double TotalHora { get; set; }

        public TempoDeServico()
        {
        }

        public TempoDeServico(ReservistaM reservista_IdReservista, double horaExtra, double totalHora)
        {
            Reservista_IdReservista = reservista_IdReservista;
            HoraExtra = horaExtra;
            TotalHora = totalHora;
        }
    }
}
