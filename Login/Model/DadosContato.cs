using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class DadosContato
    {
        public ReservistaM Reservista_IdReservista { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular{ get; set; }
        public string Email { get; set; }

        public DadosContato()
        {
        }

        public DadosContato(ReservistaM reservista_IdReservista, string telefoneFixo, string telefoneCelular, string email)
        {
            Reservista_IdReservista = reservista_IdReservista;
            TelefoneFixo = telefoneFixo;
            TelefoneCelular = telefoneCelular;
            Email = email;
        }
    }
}
