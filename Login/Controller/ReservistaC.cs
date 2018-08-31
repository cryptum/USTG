using Login.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Controller
{
    class ReservistaC
    {
        public int Salvar(ReservistaM reservista)
        {
            try {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);
            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando = conexao.CreateCommand();
            comando.CommandText = "insert into Reservista values(" +
                "@IdReservista," +
                "@NomeGuerra," +
                "@Profissao," +
                "@LocalTrabalho," +
                "@Escolaridade," +
                "@Voluntario," +
                "@Religiao," +
                "@Folgas," +
                "@Status," +
                "@Patente," +
                "@Ingressao)";
            comando.Parameters.AddWithValue("@IdReservista", null);
            comando.Parameters.AddWithValue("@NomeGuerra", reservista.NomeGuerra);
            comando.Parameters.AddWithValue("@Profissao", reservista.Profissao);
            comando.Parameters.AddWithValue("@LocalTrabalho", reservista.LocalTrabalho);
            comando.Parameters.AddWithValue("@Escolaridade", reservista.Escolaridade);
            comando.Parameters.AddWithValue("@Voluntario", reservista.Voluntario);
            comando.Parameters.AddWithValue("@Religiao", reservista.Religiao);
            comando.Parameters.AddWithValue("@Folgas", reservista.Folgas);
            comando.Parameters.AddWithValue("@Status", reservista.Status);
            comando.Parameters.AddWithValue("@Patente", reservista.Patente);
            comando.Parameters.AddWithValue("@Ingressao", reservista.Ingressao);
            int retorno = comando.ExecuteNonQuery();
            conexao.Close();
            
            return retorno;
            }
            catch(SqlException)
            {
                return 0;
            }
        }

        public int SalvarDadosPessoal(DadosPessoalM DP)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
                MySqlConnection conexao = new MySqlConnection(conn);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "insert into DadosPessoal values(" +
                    "@Reservista_IdReservista," +
                    "@NomeCompleto," +
                    "@DataNascimento," +
                    "@NomeMae," +
                    "@NomePai)";
                comando.Parameters.AddWithValue("@Reservista_IdReservista", DP.Reservista_IdReservista);
                comando.Parameters.AddWithValue("@NomeCompleto", DP.NomeCompleto);
                comando.Parameters.AddWithValue("@DataNascimento", DP.DataNascimento);
                comando.Parameters.AddWithValue("@NomeMae", DP.NomeMae);
                comando.Parameters.AddWithValue("@NomePai", DP.NomePai);
                int retorno = comando.ExecuteNonQuery();
                conexao.Close();

                return retorno;
            }
            catch (SqlException)
            {
                return 0;
            }
        }

        public int SalvarDadosDomicilio(DadosDomicilioM DD)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
                MySqlConnection conexao = new MySqlConnection(conn);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "insert into DadosDomicilio values(" +
                    "@Reservista_IdReservista," +
                    "@Endereco," +
                    "@Bairro," +
                    "@CidadeNatal)";
                comando.Parameters.AddWithValue("@Reservista_IdReservista", DD.Reservista_IdReservista);
                comando.Parameters.AddWithValue("@Endereco", DD.Endereco);
                comando.Parameters.AddWithValue("@Bairro", DD.Bairro);
                comando.Parameters.AddWithValue("@CidadeNatal", DD.CidadeNatal);
                int retorno = comando.ExecuteNonQuery();
                conexao.Close();

                return retorno;
            }
            catch (SqlException)
            {
                return 0;
            }
        }
        public int SalvarDadosContato(DadosContatoM DC)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
                MySqlConnection conexao = new MySqlConnection(conn);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "insert into DadosContato values(" +
                    "@Reservista_IdReservista," +
                    "@TelefoneFixo," +
                    "@TelefoneCelular," +
                    "@Email)";
                comando.Parameters.AddWithValue("@Reservista_IdReservista", DC.Reservista_IdReservista);
                comando.Parameters.AddWithValue("@TelefoneFixo", DC.TelefoneFixo);
                comando.Parameters.AddWithValue("@TelefoneCelular", DC.TelefoneCelular);
                comando.Parameters.AddWithValue("@Email", DC.Email);
                int retorno = comando.ExecuteNonQuery();
                conexao.Close();

                return retorno;
            }
            catch (SqlException)
            {
                return 0;
            }
        }

        public int SalvarDadosDocumento(DadosDocumentoM DD)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
                MySqlConnection conexao = new MySqlConnection(conn);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "insert into DadosPessoal values(" +
                    "@Reservista_IdReservista," +
                    "@RA," +
                    "@identidade," +
                    "@CPF," +
                    "@TituloEleitor)";
                comando.Parameters.AddWithValue("@Reservista_IdReservista", DD.Reservista_IdReservista);
                comando.Parameters.AddWithValue("@RA", DD.RA);
                comando.Parameters.AddWithValue("@identidade", DD.Identidade);
                comando.Parameters.AddWithValue("@CPF", DD.CPF);
                comando.Parameters.AddWithValue("@TituloEleitor", DD.TituloEleitoral);
                int retorno = comando.ExecuteNonQuery();
                conexao.Close();

                return retorno;
            }
            catch (SqlException)
            {
                return 0;
            }
        }

        public List<ReservistaM> CarregarTodosReservista() {
            List<ReservistaM> listaDeRetorno = new List<ReservistaM>();//Crie uma lista de Cliente
            
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);
            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando = conexao.CreateCommand();
            comando.CommandText = "Select * from  Reservista";
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())//Enquanto existir dados no select
            {
                ReservistaM reservista = new ReservistaM();//Estancia objeto do tipo cliente
                reservista.IdReservista = Convert.ToInt16(reader["IdReservista"]);
                reservista.NomeGuerra = reader["NomeGuerra"].ToString();
                reservista.Profissao = reader["Profissao"].ToString();
                reservista.LocalTrabalho = reader["LocalTrabalho"].ToString();
                reservista.Escolaridade = reader["Escolaridade"].ToString();
                //reservista.Voluntario = reader["Voluntario"];
                reservista.Religiao = reader["Religiao"].ToString();
                reservista.Status = reader["Folgas"].ToString();
                //reservista.Patente = Convert.ToBoolean(reader["Patente"]);
                reservista.Ingressao = reader["Ingressao"].ToString();
                listaDeRetorno.Add(reservista);//Adiciona na lista um objeto do tipo cliente
            }
            conexao.Close();//Fecha Conexao
            return listaDeRetorno;
        }
        
    }
}
