using Login.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    }
}
