using System;
using System.Collections.Generic;

#nullable disable

namespace Hardware_house.Infra.Entities
{
    public partial class UsuarioTelefone
    {
        public string Email { get; set; }
        public string UsuarioCpf { get; set; }

        public virtual Usuario UsuarioCpfNavigation { get; set; }
    }
}
