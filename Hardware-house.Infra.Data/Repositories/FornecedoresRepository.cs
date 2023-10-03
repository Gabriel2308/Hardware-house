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
    public class FornecedoresRepository : PostgreConnection
    {
        public Fornecedor GetFornecedorById(int id)
        {
            Fornecedor fornecedor = new Fornecedor();

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"SELECT * FROM mydb.fornecedores WHERE id = {id}";

                command.Connection = conn;
                conn.Open();

                NpgsqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    fornecedor.id = Convert.ToInt32(dataReader["id"]);
                    fornecedor.cnpj = Convert.ToString(dataReader["cnpj"]);
                    fornecedor.uf = Convert.ToString(dataReader["uf"]);
                    fornecedor.email = Convert.ToString(dataReader["email"]);
                    fornecedor.telefone = Convert.ToString(dataReader["telefone"]);
                    fornecedor.cidade = Convert.ToString(dataReader["cidade"]);
                    fornecedor.nomeEmpresa = Convert.ToString(dataReader["nomeempresa"]);
                    
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

            return fornecedor;
        }

        public Object CreateNewFornecedor(Fornecedor fornecedor)
        {

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"INSERT INTO mydb.fornecedores (id, email, telefone, uf, cidade, cnpj, nomeempresa)" +
                                        $"VALUES (@id, @email, @telefone, @uf, @cidade, @cnpj, @nomeempresa);";

                command.Parameters.AddWithValue("@id", fornecedor.id);
                command.Parameters.AddWithValue("@email", fornecedor.email);
                command.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                command.Parameters.AddWithValue("@uf", fornecedor.uf);
                command.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                command.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                command.Parameters.AddWithValue("@nomeempresa", fornecedor.nomeEmpresa);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Fornecedor criado com sucesso";
                }
                else
                {
                    return "Erro ao criar novo Fornecedor";
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

        public Object DeleteFornecedor(int id)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"DELETE FROM mydb.fornecedores WHERE id = @id";

                command.Parameters.AddWithValue("@id", id);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Fornecedor deletado com sucesso";
                }
                else
                {
                    return "Erro ao deletar Fornecedor";
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

        public Object UpdateFornecedor(int id, Fornecedor fornecedor)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"UPDATE mydb.fornecedores " +
                                       $"SET email = @email, telefone = @telefone, uf = @uf, cidade = @cidade, cnpj = @cnpj, nomeempresa = @nomeempresa " +
                                       $"WHERE id = @id";

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@email", fornecedor.email);
                command.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                command.Parameters.AddWithValue("@uf", fornecedor.uf);
                command.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                command.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                command.Parameters.AddWithValue("@nomeempresa", fornecedor.nomeEmpresa);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Fornecedor atualizado com sucesso";
                }
                else
                {
                    return "Erro ao atualizar Fornecedor";
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
