namespace Hardware_house.Infra.Entities
{
    public class Funcionario
    {
        public int idtipo { get; set; }
        public string matricula { get; set; }
        public int idtipofuncionario { get; set; }
        public DateTime data_admissao { get; set; }
        public DateTime data_demissao { get; set; }
        public string status { get; set; }
        public string usuario_cpf { get; set; }
    }
}
