namespace Hardware_house.Infra.Entities
{
    public class Cursa
    {
        public string MatEstudante { get; set; }
        public int IdTurma { get; set; }
        public float? Nota { get; set; }

        public virtual Turma IdTurmaNavigation { get; set; }
        public virtual Estudante MatEstudanteNavigation { get; set; }
    }
}
