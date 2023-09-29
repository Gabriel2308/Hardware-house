namespace Hardware_house.Infra.Entities
{
    public class Leciona
    {
        public int IdTurma { get; set; }
        public string MatProfessor { get; set; }

        public virtual Turma IdTurmaNavigation { get; set; }
        public virtual Professor MatProfessorNavigation { get; set; }
    }
}
