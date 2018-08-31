using Login.Model;
using Login.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ControleFaltaView : Form
    {
        ControleDeFaltaM controledefalta = new ControleDeFaltaM();
        ControleDeFaltaC controledefaltaDao = new ControleDeFaltaC();

        ReservistaM reservista = new ReservistaM();
        ReservistaC reservistadao = new ReservistaC();
        List<ReservistaM> listaDeRetorno = new List<ReservistaM>();
        public ControleFaltaView()
        {
            InitializeComponent();
        }

        private void ControleFalta_Load(object sender, EventArgs e)
        {
            listaDeRetorno = new List<ReservistaM>();
            listaDeRetorno = reservistadao.CarregarTodosReservista();
            tblFalta.DataSource = listaDeRetorno; //Passa lista de cliente para a gridView
        }
    }
}
