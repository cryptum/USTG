using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class ReservistaM
    {
        public int IdReservista { get; set; }
        public string NomeGuerra { get; set; }
        public string Profissao { get; set; }
        public string LocalTrabalho { get; set; }
        public string Escolaridade { get; set; }
        public bool Voluntario { get; set; }
        public string Religiao { get; set; }
        public int Folgas { get; set; }
        public string Status { get; set; }
        public bool Patente { get; set; }
        public string Ingressao { get; set; }

        public ReservistaM()
        {
        }

        public ReservistaM(int idReservista, string nomeGuerra, string profissao, string localTrabalho, string escolaridade, bool voluntario, string religiao, int folgas, string status, bool patente, string ingressao)
        {
            IdReservista = idReservista;
            NomeGuerra = nomeGuerra;
            Profissao = profissao;
            LocalTrabalho = localTrabalho;
            Escolaridade = escolaridade;
            Voluntario = voluntario;
            Religiao = religiao;
            Folgas = folgas;
            Status = status;
            Patente = patente;
            Ingressao = ingressao;
        }
    }
}
