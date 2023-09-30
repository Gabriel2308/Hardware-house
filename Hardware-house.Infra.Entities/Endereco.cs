using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public string Numero { get; set; }
        public string UsuarioCpf { get; set; }

        public virtual Usuario UsuarioCpfNavigation { get; set; }
    }
}
