namespace Hardware_house.Infra.Entities
{
    public class Estudante
    {
        public Estudante()
        {
            Cursas = new HashSet<Cursa>();
            Planos = new HashSet<Plano>();
        }

        public string MatEstudante { get; set; }
        public long? Cpf { get; set; }
        public double? Mc { get; set; }

        public virtual Usuario CpfNavigation { get; set; }
        public virtual ICollection<Cursa> Cursas { get; set; }
        public virtual ICollection<Plano> Planos { get; set; }
    }
}
