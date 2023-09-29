using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Funcionario
    {
        public string Matricula { get; set; }
        public int Idtipo { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public string Status { get; set; }
        public string UsuarioCpf { get; set; }
        public int Idtipofuncionario { get; set; }

        public virtual Tipofuncionario IdtipofuncionarioNavigation { get; set; }
        public virtual Usuario UsuarioCpfNavigation { get; set; }
        public virtual Funcionariopossui Funcionariopossui { get; set; }
    }
}
