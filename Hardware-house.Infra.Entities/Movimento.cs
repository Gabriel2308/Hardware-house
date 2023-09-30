using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Movimento
    {
        public Movimento()
        {
            Carrinhos = new HashSet<Carrinho>();
        }

        public int Id { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public string StatusMovimento { get; set; }
        public int Idcarrinho { get; set; }

        public virtual ICollection<Carrinho> Carrinhos { get; set; }
    }
}
