using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class TempoDeServicoM
    {
        public ReservistaM Reservista_IdReservista { get; set; }
        public double HoraExtra { get; set; }
        public double TotalHora { get; set; }

        public TempoDeServicoM()
        {
        }

        public TempoDeServicoM(ReservistaM reservista_IdReservista, double horaExtra, double totalHora)
        {
            Reservista_IdReservista = reservista_IdReservista;
            HoraExtra = horaExtra;
            TotalHora = totalHora;
        }
    }
}
