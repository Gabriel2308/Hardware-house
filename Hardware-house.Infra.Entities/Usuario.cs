namespace Hardware_house.Infra.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Funcionarios = new HashSet<Funcionario>();
            UsuarioTelefones = new HashSet<UsuarioTelefone>();
        }

        public string Cpf { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNasc { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<UsuarioTelefone> UsuarioTelefones { get; set; }
    }
}
