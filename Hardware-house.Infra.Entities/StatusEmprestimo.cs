namespace Hardware_house.Infra.Entities
{
    public class StatusEmprestimo
    {
        public StatusEmprestimo()
        {
            Emprestimos = new HashSet<Emprestimo>();
        }

        public int IdStatus { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
