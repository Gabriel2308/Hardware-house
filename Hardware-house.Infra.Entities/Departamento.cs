namespace Hardware_house.Infra.Entities
{
    public class Departamento
    {
        public Departamento()
        {
            Disciplinas = new HashSet<Disciplina>();
            Professors = new HashSet<Professor>();
        }

        public string CodDepto { get; set; }
        public string Nome { get; set; }
        public string Chefe { get; set; }
        public float? Orcamento { get; set; }

        public virtual Professor ChefeNavigation { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
    }
}
