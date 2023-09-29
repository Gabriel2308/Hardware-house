namespace Hardware_house.Infra.Entities
{
    public class Emprestimo
    {
        public int IdEmprestimo { get; set; }
        public int IdExemplar { get; set; }
        public long Cpf { get; set; }
        public int Status { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataEntrega { get; set; }

        public virtual Usuario CpfNavigation { get; set; }
        public virtual Exemplar IdExemplarNavigation { get; set; }
        public virtual StatusEmprestimo StatusNavigation { get; set; }
    }
}
