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
                    "@IdDataIndisponivel," +
                    "@Reservista_IdReservista," +
                    "@LocalTrabalho," +
                    "@Escolaridade," +
                    "@Voluntario," +
                    "@Religiao," +
                    "@Folgas," +
                    "@Status," +
                    "@Patente," +
                    "@Ingressao)";
                comando.Parameters.AddWithValue("@IdReservista", null);
                comando.Parameters.AddWithValue("@NomeGuerra", dataDisp.IdDataDisponivel);
                comando.Parameters.AddWithValue("@Profissao", dataDisp.Reservista_IdReservista);
                comando.Parameters.AddWithValue("@LocalTrabalho", dataDisp.Data);
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
