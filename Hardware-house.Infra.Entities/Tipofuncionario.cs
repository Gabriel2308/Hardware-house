using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Tipofuncionario
    {
        public Tipofuncionario()
        {
            Funcionarios = new HashSet<Funcionario>();
        }

        public int Idtipofuncionario { get; set; }
        public string DescricaoTipoFuncionario { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
