using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Pagamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public string TipoPagamento { get; set; }
        public int IdCarrinho { get; set; }

        public virtual Carrinho IdCarrinhoNavigation { get; set; }
    }
}
