namespace Hardware_house.Infra.Entities
{
    public class Plano
    {
        public int? IdProjeto { get; set; }
        public string MatProfessor { get; set; }
        public string MatEstudante { get; set; }
        public int Ano { get; set; }

        public virtual Projeto IdProjetoNavigation { get; set; }
        public virtual Estudante MatEstudanteNavigation { get; set; }
        public virtual Professor MatProfessorNavigation { get; set; }
    }
}
