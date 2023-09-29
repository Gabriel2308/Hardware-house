namespace Hardware_house.Infra.Entities
{
    public class Disciplina
    {
        public Disciplina()
        {
            InversePreReqNavigation = new HashSet<Disciplina>();
            Turmas = new HashSet<Turma>();
        }

        public string CodDisc { get; set; }
        public string Nome { get; set; }
        public string PreReq { get; set; }
        public short? Creditos { get; set; }
        public string DeptoResponsavel { get; set; }

        public virtual Departamento DeptoResponsavelNavigation { get; set; }
        public virtual Disciplina PreReqNavigation { get; set; }
        public virtual ICollection<Disciplina> InversePreReqNavigation { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}
