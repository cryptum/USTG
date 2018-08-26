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
            txtNomeCompleto.Text = String.Empty;
            txtDataNascimento.Text = String.Empty;
            txtNomeMae.Text = String.Empty;
            txtNomePai.Text = String.Empty;
            //Dados Domicilio
            txtEndereco.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCidadeNatal.Text = String.Empty;
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

    }
}
