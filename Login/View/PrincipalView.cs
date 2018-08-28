using Login.View;
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
    public partial class PrincipalView : Form
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void PrincipalView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EscalaDeGuardaView escala = new EscalaDeGuardaView();
            escala.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ControleFaltaView falta = new ControleFaltaView();
            falta.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TAFView taf = new TAFView();
            taf.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DatasView data = new DatasView();
            data.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ReservistaView reser = new ReservistaView();
            reser.ShowDialog();
        }
    }
}
