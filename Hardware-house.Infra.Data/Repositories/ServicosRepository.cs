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
    public class ServicosRepository : PostgreConnection
    {
        public Servico GetServico(int id)
        {
            Servico servico = new Servico();

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"SELECT * FROM mydb.servicos WHERE id = {id}";

                command.Connection = conn;
                conn.Open();

                NpgsqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    servico.Nome = Convert.ToString(dataReader["nome"]);
                    servico.Tipo = Convert.ToString(dataReader["tipo"]);
                    servico.Id = Convert.ToInt32(dataReader["id"]);
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
            return servico;
        }

        public Object PostServico(Servico servico)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"INSERT INTO mydb.servicos (id, nome, tipo) " +
                                        $"VALUES (@id, @nome, @tipo);";

                command.Parameters.AddWithValue("@id", servico.Id);
                command.Parameters.AddWithValue("@nome", servico.Nome);
                command.Parameters.AddWithValue("@tipo", servico.Tipo);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Servico criado com sucesso";
                }
                else
                {
                    return "Erro ao criar novo servico";
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
        public Object DeleteServico(int id)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"DELETE FROM mydb.servicos WHERE id = @id";

                command.Parameters.AddWithValue("@id", id);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Servico deletado com sucesso";
                }
                else
                {
                    return "Erro ao deletar novo servico";
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

        public Object UpdateServico(int id, Servico servico)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"UPDATE mydb.servicos " +
                                       $"SET id = @id, tipo = @tipo, nome = @nome " +
                                       $"WHERE id = @id";

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@tipo", servico.Tipo);
                command.Parameters.AddWithValue("@nome", servico.Nome);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Servico atualizado com sucesso";
                }
                else
                {
                    return "Erro ao atualizar Servico";
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
        }
    }
}
