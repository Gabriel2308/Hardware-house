namespace Hardware_house.Infra.Entities
{
    public class Semestre
    {
        public Semestre()
        {
            Turmas = new HashSet<Turma>();
        }

        public short Ano { get; set; }
        public short Semestre1 { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFom { get; set; }

        public virtual ICollection<Turma> Turmas { get; set; }
    }
}
