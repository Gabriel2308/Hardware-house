using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Carrinho
    {
        public Carrinho()
        {
            Items = new HashSet<Item>();
            Pagamentos = new HashSet<Pagamento>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public int Idmovimento { get; set; }
        public string ClienteUsuarioCpf { get; set; }

        public virtual Cliente ClienteUsuarioCpfNavigation { get; set; }
        public virtual Movimento IdmovimentoNavigation { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}
