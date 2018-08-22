using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class ServidorC
    {

        public int Validacao(ServidorM servidor)
        {
            int retorno = 0;
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);
            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando = conexao.CreateCommand();
            comando.CommandText = "Select * from servidor where login = @usu and senha = @sen";
            comando.Parameters.AddWithValue("usu", servidor.Login);
            comando.Parameters.AddWithValue("sen", servidor.Senha);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if(reader["NomeCompleto"] != null)
                {
                    retorno++;
                }
            }
            conexao.Close();
            return retorno;
        }
    }
}
