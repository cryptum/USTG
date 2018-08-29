using Login.Controller;
using Login.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.View
{
    public partial class ReservistaView : Form
    {
        ReservistaM reservista = new ReservistaM();
        ReservistaC reservistadao = new ReservistaC();
        public ReservistaView()
        {
            InitializeComponent();
            txtId.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {   //Dados Reservista
            txtId.Text = String.Empty;
            txtNomeGuerra.Text = String.Empty;
            txtProfissao.Text = String.Empty;
            txtLocalTrabalho.Text = String.Empty;
            cbxEscolaridade.SelectedIndex = 0;
            SimVoluntario.Checked = false;
            NaoVoluntario.Checked = false;
            txtReligiao.Text = String.Empty;
            cbxSituacao.SelectedIndex = 0;
            PatenteCabo.Checked = false;
            PatenteSentinela.Checked = false;
            txtIngressao.Text = String.Empty;
            //Dados pessoais
            txtNomePai.Text = String.Empty;
            txtDataNascimento.Text = String.Empty;
            txtNomeMae.Text = String.Empty;
            txtNomeCompleto.Text = String.Empty;
            //Dados Domicilio
            txtCidadeNatal.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtBairro.Text = String.Empty;
            //Dados Contatos
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtEmail.Text = String.Empty;
            //Dados Documentos
            txtRA.Text = String.Empty;
            txtIdentidade.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtTituloEleitor.Text = String.Empty;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            reservista = new ReservistaM();
            if (SimVoluntario.Checked == true)
            {
                reservista.Voluntario = true;
            }
            else
            {
                reservista.Voluntario = false;
            }
            if (PatenteSentinela.Checked == true)
            {
                reservista.Patente = true;
            }
            else
            {
                reservista.Patente = false;
            }
            reservista.NomeGuerra = txtNomeGuerra.Text.Trim();
            reservista.Profissao = txtProfissao.Text.Trim();
            reservista.LocalTrabalho = txtLocalTrabalho.Text.Trim();
            reservista.Escolaridade = cbxEscolaridade.Text;
            reservista.Religiao = txtReligiao.Text.Trim();
            reservista.Status = cbxSituacao.Text;
            reservista.Ingressao = txtIngressao.Text.Trim();

            int retorno = reservistadao.Salvar(reservista);
            if(retorno == 1)
            {
                MessageBox.Show("           Salvo Com Sucesso!      ");
            }
            else
            {
                MessageBox.Show("Deu ruim");
            }
        }
    }
}
