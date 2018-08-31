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
    class DatasC
    {
        public int SalvarPunicao(DataDisponivelM dataDisp)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
                MySqlConnection conexao = new MySqlConnection(conn);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "insert into DataDisponivel values(" +
                    "@IdDataDisponivel," +
                    "@Reservista_IdReservista," +
                    "@Data)";
                comando.Parameters.AddWithValue("@IdDataDisponivel", null);
                comando.Parameters.AddWithValue("@Reservista_IdReservista", dataDisp.Reservista_IdReservista);
                comando.Parameters.AddWithValue("@Data", dataDisp.Data);
                int retorno = comando.ExecuteNonQuery();
                conexao.Close();

                return retorno;
            }
            catch (SqlException)
            {
                return 0;
            }
        }

        public int SalvarDispensa(DataIndisponivelM dataIndisp)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
                MySqlConnection conexao = new MySqlConnection(conn);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "insert into DataIndisponivel values(" +
                    "@IdDataIndisponivel," +
                    "@Reservista_IdReservista," +
                    "@Data)";
                comando.Parameters.AddWithValue("@IdDataIndisponivel", null);
                comando.Parameters.AddWithValue("@Reservista_IdReservista", dataIndisp.Reservista_IdReservista);
                comando.Parameters.AddWithValue("@Data", dataIndisp.Data);
                int retorno = comando.ExecuteNonQuery();
                conexao.Close();

                return retorno;
            }
            catch (SqlException)
            {
                return 0;
            }
        }
    }
}
