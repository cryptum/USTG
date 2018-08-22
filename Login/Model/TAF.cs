using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class TAF
    {
        public int IdTaf { get; set; }
        public ReservistaM Reservista_IdReservista { get; set; }
        public string Data { get; set; }
        public int Barra { get; set; }
        public int Flexao { get; set; }
        public int Abdominal { get; set; }
        public int Corrida { get; set; }

        public TAF()
        {
        }

        public TAF(int idTaf, ReservistaM reservista_IdReservista, string data, int barra, int flexao, int abdominal, int corrida)
        {
            IdTaf = idTaf;
            Reservista_IdReservista = reservista_IdReservista;
            Data = data;
            Barra = barra;
            Flexao = flexao;
            Abdominal = abdominal;
            Corrida = corrida;
        }
    }
}
