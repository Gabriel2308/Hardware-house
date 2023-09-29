namespace Hardware_house.Infra.Entities
{
    public class Endereco
    {
        public Endereco()
        {
            Moras = new HashSet<Mora>();
        }

        public int IdEndereco { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public virtual ICollection<Mora> Moras { get; set; }
    }
}
