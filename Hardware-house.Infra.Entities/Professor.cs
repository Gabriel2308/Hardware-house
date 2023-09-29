namespace Hardware_house.Infra.Entities
{
    public class Professor
    {
        public Professor()
        {
            Departamentos = new HashSet<Departamento>();
            Lecionas = new HashSet<Leciona>();
            Planos = new HashSet<Plano>();
        }

        public string MatProfessor { get; set; }
        public long? Cpf { get; set; }
        public int Cargo { get; set; }
        public string Departamento { get; set; }

        public virtual Cargo CargoNavigation { get; set; }
        public virtual Usuario CpfNavigation { get; set; }
        public virtual Departamento DepartamentoNavigation { get; set; }
        public virtual ICollection<Departamento> Departamentos { get; set; }
        public virtual ICollection<Leciona> Lecionas { get; set; }
        public virtual ICollection<Plano> Planos { get; set; }
    }
}
