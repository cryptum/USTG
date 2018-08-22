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
            ServidorM servidor = new ServidorM();
            ServidorC servidordao = new ServidorC();

            public Login()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                servidor.Login = txtusuario.Text;
                servidor.Senha = txtsenha.Text;
                try
                {
                    int retorno = servidordao.Validacao(servidor);
                    if (retorno != 1)
                    {
                        MessageBox.Show("Não foi possivel logar");
                    }
                    else
                    {
                        PrincipalView prin = new PrincipalView();
                        prin.Show();
                        this.Visible = false;
                    }

                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Não foi possivel logar! \nDeu Erro: " + msqle.Message, "ERRO");
                }
                finally
                {

                }
            }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
