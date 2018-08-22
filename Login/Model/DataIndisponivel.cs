using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class DataIndisponivel
    {
        public int IdDataIndisponivel { get; set; }
        public ReservistaM Reservista_IdReservista { get; set; }
        public string Data { get; set; }

        public DataIndisponivel()
        {
        }

        public DataIndisponivel(int IdDataIndisponivel, ReservistaM reservista_IdReservista, string data)
        {
            IdDataIndisponivel = IdDataIndisponivel;
            Reservista_IdReservista = reservista_IdReservista;
            Data = data;
        }
    }
}
