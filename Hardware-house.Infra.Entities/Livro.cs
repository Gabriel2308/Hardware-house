namespace Hardware_house.Infra.Entities
{
    public class Livro
    {
        public Livro()
        {
            Exemplars = new HashSet<Exemplar>();
        }

        public long Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int? NumeroPaginas { get; set; }
        public int? Edicao { get; set; }

        public virtual ICollection<Exemplar> Exemplars { get; set; }
    }
}
