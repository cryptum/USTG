﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class EscalaDeGuarda
    {
        public int IdEscalaDeGuarda { get; set; }
        public ReservistaM Reservista_IdReservista { get; set; }
        public string DataDaGuarda { get; set; }

        public EscalaDeGuarda()
        {
        }

        public EscalaDeGuarda(int idEscalaDeGuarda, ReservistaM reservista_IdReservista, string dataDaGuarda)
        {
            IdEscalaDeGuarda = idEscalaDeGuarda;
            Reservista_IdReservista = reservista_IdReservista;
            DataDaGuarda = dataDaGuarda;
        }
    }
}
