using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Categoriaproduto
    {
        public Categoriaproduto()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string DescricaoCategoria { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
