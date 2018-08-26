using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class DataDisponivelM
    {
        public int IdDataDisponivel { get; set; }
        public ReservistaM Reservista_IdReservista { get; set; }
        public string Data { get; set; }

        public DataDisponivelM()
        {
        }

        public DataDisponivelM(int idDataDisponivel, ReservistaM reservista_IdReservista, string data)
        {
            IdDataDisponivel = idDataDisponivel;
            Reservista_IdReservista = reservista_IdReservista;
            Data = data;
        }
    }
}
