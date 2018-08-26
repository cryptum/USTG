using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class DataIndisponivelM
    {
        public int IdDataIndisponivel { get; set; }
        public ReservistaM Reservista_IdReservista { get; set; }
        public string Data { get; set; }

        public DataIndisponivelM()
        {
        }

        public DataIndisponivelM(int idDataIndisponivel, ReservistaM reservista_IdReservista, string data)
        {
            IdDataIndisponivel = idDataIndisponivel;
            Reservista_IdReservista = reservista_IdReservista;
            Data = data;
        }
    }
}
