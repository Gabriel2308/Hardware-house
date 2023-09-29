using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Carrinhos = new HashSet<Carrinho>();
        }

        public string UsuarioCpf { get; set; }

        public virtual Usuario UsuarioCpfNavigation { get; set; }
        public virtual ICollection<Carrinho> Carrinhos { get; set; }
    }
}
