using Hardware_house.Infra.Data.DbConfig;
using Hardware_house.Infra.Entities;
using Npgsql;

namespace Hardware_house.Infra.Data.Repositories
{
    public class ProdutoRepository : PostgreConnection
    {     
        public List<Produto> GetProdutos()
        {
            Produto produto;
            List<Produto> produtos;
            try
            {
                 NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
                NpgsqlCommand command = new NpgsqlCommand();

                command.CommandText = $"SELECT * FROM mydb.produtos";

                command.Connection = conn;
                conn.Open();

                NpgsqlDataReader dataReader = command.ExecuteReader();

                produtos = new();
                if (dataReader.HasRows)
                {
                    produto = new();

                    dataReader.Read();
                    produto.Id = Convert.ToInt32(dataReader["id"]);
                    produto.Nome = Convert.ToString(dataReader["nome"]);
                    produto.Preco = Convert.ToDecimal(dataReader["preco"]);
                    produto.QtdProduto = Convert.ToInt32(dataReader["qtd_produto"]);
                    produto.IdCategoria = Convert.ToInt32(dataReader["id_categoria"]);
                    produto.IdFornecedores = Convert.ToInt32(dataReader["id_fornecedores"]);
                    produtos.Add(produto);
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

            return produtos;
        }
    }
}
