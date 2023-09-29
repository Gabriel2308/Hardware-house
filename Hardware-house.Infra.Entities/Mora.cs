namespace Hardware_house.Infra.Entities
{
    public class Mora
    {
        public int IdEndereco { get; set; }
        public long Cpf { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }

        public virtual Usuario CpfNavigation { get; set; }
        public virtual Endereco IdEnderecoNavigation { get; set; }
    }
}
