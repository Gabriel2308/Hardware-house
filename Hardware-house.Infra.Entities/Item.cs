using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Item
    {
        public Item()
        {
            Funcionariopossuis = new HashSet<Funcionariopossui>();
        }

        public int IdServicos { get; set; }
        public int CarrinhoId { get; set; }
        public int ProdutosId { get; set; }

        public virtual Carrinho Carrinho { get; set; }
        public virtual Servico IdServicosNavigation { get; set; }
        public virtual Produto Produtos { get; set; }
        public virtual ICollection<Funcionariopossui> Funcionariopossuis { get; set; }
    }
}
