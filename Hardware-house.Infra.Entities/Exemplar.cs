namespace Hardware_house.Infra.Entities
{
    public class Exemplar
    {
        public Exemplar()
        {
            Emprestimos = new HashSet<Emprestimo>();
        }

        public int IdExemplar { get; set; }
        public long Isbn { get; set; }
        public int Numero { get; set; }

        public virtual Livro IsbnNavigation { get; set; }
        public virtual ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
