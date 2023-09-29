namespace Hardware_house.Infra.Entities
{
    public class Turma
    {
        public Turma()
        {
            Cursas = new HashSet<Cursa>();
            Lecionas = new HashSet<Leciona>();
        }

        public int IdTurma { get; set; }
        public string CodDisc { get; set; }
        public int? Numero { get; set; }
        public short? Ano { get; set; }
        public short? Semestre { get; set; }

        public virtual Disciplina CodDiscNavigation { get; set; }
        public virtual Semestre SemestreNavigation { get; set; }
        public virtual ICollection<Cursa> Cursas { get; set; }
        public virtual ICollection<Leciona> Lecionas { get; set; }
    }
}
