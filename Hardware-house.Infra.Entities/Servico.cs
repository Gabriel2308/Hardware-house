using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Servico
    {
        //public Servico()
        //{
        //    Items = new HashSet<Item>();
        //}

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
