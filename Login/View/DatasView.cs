using Login.Controller;
using Login.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.View
{
    public partial class DatasView : Form
    {
        DataDisponivelM dataDisponivel = new DataDisponivelM();
        DataIndisponivelM dataIndisponivel = new DataIndisponivelM();
        DatasC datasdao = new DatasC();
        public DatasView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dataDisponivel = new DataDisponivelM();
            dataIndisponivel = new DataIndisponivelM();
            if (cbxReservista.Text.Equals(String.Empty) || cbxAcao.Text.Equals(String.Empty) || txtData.Text.Equals(String.Empty)) {
                MessageBox.Show("Existe Campos Imcompletos");
            }
            else
            {
                if (cbxAcao.SelectedIndex == 0)
                {
                    MessageBox.Show("Selecione alguma ação");
                }
                else if (cbxAcao.SelectedIndex == 1)
                {
                    //dataDisponivel.Reservista_IdReservista = cbxReservista.SelectedIndex();
                    dataDisponivel.Data = txtData.Text;
                    datasdao.SalvarPunicao(dataDisponivel);
                }
                else if (cbxAcao.SelectedIndex == 2)
                {
                    //dataIndisponivel.Reservista_IdReservista = cbxReservista.SelectedIndex();
                    dataIndisponivel.Data = txtData.Text;
                    datasdao.SalvarDispensa(dataIndisponivel);
                }
            }
        }

        private void DatasView_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);
            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando = conexao.CreateCommand();
            comando.CommandText = "Select * from Reservista";
            MySqlDataReader  resultado = comando.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    cbxReservista.Items.Add(resultado["NomeGuerra"]);
                }
            }
        }
    }
}
