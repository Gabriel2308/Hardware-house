namespace Hardware_house.Infra.Entities
{
    public partial class Projeto
    {
        public Projeto()
        {
            Planos = new HashSet<Plano>();
        }

        public int IdProjeto { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Plano> Planos { get; set; }
    }
}
