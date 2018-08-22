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

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "Select * from servidor where login = @usu and senha = @sen";
                comando.Parameters.AddWithValue("usu", txtusuario.Text.Trim());
                comando.Parameters.AddWithValue("sen", txtusuario.Text.Trim());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if(reader["NomeCompleto"] != null)
                    {
                        MessageBox.Show(reader["NomeCompleto"].ToString());
                    }
                }

                MessageBox.Show("Deu bom");
            }
            catch(MySqlException msqle)
            {
                MessageBox.Show("Deu Erro: " + msqle.Message, "ERRO");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
