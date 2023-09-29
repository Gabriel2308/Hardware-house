using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QtdProduto { get; set; }
        public int IdCategoria { get; set; }
        public int IdFornecedores { get; set; }

        public virtual Categoriaproduto IdCategoriaNavigation { get; set; }
        public virtual Fornecedore IdFornecedoresNavigation { get; set; }
        public virtual Item Item { get; set; }
    }
}
