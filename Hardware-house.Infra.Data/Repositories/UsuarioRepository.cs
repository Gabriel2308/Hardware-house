using Hardware_house.Infra.Data.DbConfig;
using Hardware_house.Infra.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_house.Infra.Data.Repositories
{
    public class UsuarioRepository : PostgreConnection
    {
        public Usuario GetUsuarioByCpf (string cpf)
        {
            Usuario usuario = new Usuario ();

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"SELECT * FROM mydb.usuario WHERE cpf = '{cpf}'";

                command.Connection = conn;
                conn.Open();

                NpgsqlDataReader dataReader = command.ExecuteReader();

                if(dataReader.HasRows)
                {
                    dataReader.Read();
                    usuario.cpf = Convert.ToString(dataReader["cpf"]);
                    usuario.primeiro_nome = Convert.ToString(dataReader["primeiro_nome"]);
                    usuario.sobrenome = Convert.ToString(dataReader["sobrenome"]);
                    usuario.data_nasc = Convert.ToString(dataReader["data_nasc"]);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }

            return usuario;
        }
    }
}
