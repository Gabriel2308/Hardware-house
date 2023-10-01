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
    public class ItemRepository : PostgreConnection
    {
        public Item GetItemByProdutoId(int produtoId)
        {
            Item item = new Item();

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"SELECT * FROM mydb.item WHERE produtos_id = {produtoId}";

                command.Connection = conn;
                conn.Open();

                NpgsqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    item.CarrinhoId = Convert.ToInt32(dataReader["carrinho_id"]);
                    item.IdServicos = Convert.ToInt32(dataReader["id_servicos"]);
                    item.ProdutosId = Convert.ToInt32(dataReader["produtos_id"]);
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
            return item;
        }

        public Object PostNewItem(Item item)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"INSERT INTO mydb.item (id_servicos, carrinho_id, produtos_id) " +
                                        $"VALUES (@id_servicos, @carrinho_id, @produtos_id);";

                command.Parameters.AddWithValue("@id_servicos", item.IdServicos);
                command.Parameters.AddWithValue("@carrinho_id", item.CarrinhoId);
                command.Parameters.AddWithValue("@produtos_id", item.ProdutosId);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Item criado com sucesso";
                }
                else
                {
                    return "Erro ao criar novo Item";
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

        public Object DeleteItem(int produtoId)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"DELETE FROM mydb.item WHERE produtos_id = @id";

                command.Parameters.AddWithValue("@id", produtoId);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Item deletado com sucesso";
                }
                else
                {
                    return "Erro ao deletar Item";
                }
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally 
            { 
                CloseConnection(); 
            }
        }
        public Object UppdateItem(int produtoId, Item item)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"UPDATE mydb.item " +
                                       $"SET id_servicos = @id_servicos, carrinho_id = @carrinho_id, produtos_id = @produtos_id " +
                                       $"WHERE produtos_id = @id";

                command.Parameters.AddWithValue("@id", produtoId);
                command.Parameters.AddWithValue("@id_servicos", item.IdServicos);
                command.Parameters.AddWithValue("@carrinho_id", item.CarrinhoId);
                command.Parameters.AddWithValue("@produtos_id", item.ProdutosId);

                command.Connection = conn;
                conn.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Item atualizado com sucesso";
                }
                else
                {
                    return "Erro ao atualizar Item";
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
