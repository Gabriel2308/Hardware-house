using Hardware_house.Infra.Data.Repositories;
using Hardware_house.Infra.Entities;

namespace Hardware_house.Domain.Services
{
    public class ProdutoDomain
    {
        ProdutoRepository repository = new();

        public List<Produto> GetProdutos()
        {
            return repository.GetProdutos();
        }
    }
}
