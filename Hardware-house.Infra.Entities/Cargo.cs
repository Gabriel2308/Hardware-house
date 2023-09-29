namespace Hardware_house.Infra.Entities
{
    public class Cargo
    {
        public Cargo()
        {
            Professores = new HashSet<Professor>();
        }

        public int IdCargo { get; set; }
        public string CargaHoraria { get; set; }
        public float? Salario { get; set; }

        public virtual ICollection<Professor> Professores { get; set; }
    }
}
