using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Funcionariopossui
    {
        public string FuncionarioMatricula { get; set; }
        public int ItemProdutosId { get; set; }

        public virtual Funcionario FuncionarioMatriculaNavigation { get; set; }
        public virtual Item ItemProdutos { get; set; }
    }
}
