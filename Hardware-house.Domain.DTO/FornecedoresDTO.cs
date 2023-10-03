using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_house.Domain.DTO
{
    public class FornecedoresDTO
    {
        public int id { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string uf { get; set; }
        public string cidade { get; set; }
        public string cnpj { get; set; }
        public string nomeEmpresa { get; set; }
    }
}
