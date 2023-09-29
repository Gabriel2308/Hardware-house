using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Fornecedore
    {
        public Fornecedore()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Cnpj { get; set; }
        public string Nomeempresa { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
