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
                    usuario.Cpf = Convert.ToString(dataReader["cpf"]);
                    usuario.PrimeiroNome = Convert.ToString(dataReader["primeiro_nome"]);
                    usuario.Sobrenome = Convert.ToString(dataReader["sobrenome"]);
                    usuario.DataNasc = Convert.ToDateTime(dataReader["data_nasc"]);
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

        public Object CreateUsuario(Usuario usuario)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"INSERT INTO mydb.usuario (cpf, primeiro_nome, sobrenome, data_nasc)" +
                                        $"VALUES (@cpf, @primeiro_nome, @sobrenome, @data_nasc);";

                command.Parameters.AddWithValue("@cpf", usuario.Cpf);
                command.Parameters.AddWithValue("@primeiro_nome", usuario.PrimeiroNome);
                command.Parameters.AddWithValue("@sobrenome", usuario.Sobrenome);
                command.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(usuario.DataNasc));

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Usuario criado com sucesso";
                }
                else
                {
                    return "Erro ao criar novo usuario";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public Object DeleteUsuarioByCpf(string cpf)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"DELETE FROM mydb.endereco WHERE usuario_cpf = @cpf" +
                                      $"DELETE FROM mydb.usuario WHERE cpf = @cpf";

                command.Parameters.AddWithValue("@cpf", cpf);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Usuario deletado com sucesso";
                }
                else
                {
                    return "Erro ao deletar novo usuario";
                }
            }
            catch(Exception ex) 
            { 
                throw ex; 
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
