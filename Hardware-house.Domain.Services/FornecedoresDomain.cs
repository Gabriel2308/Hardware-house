using Hardware_house.Domain.DTO;
using Hardware_house.Infra.CrossCutting.Mapper;
using Hardware_house.Infra.Data.Repositories;
using Hardware_house.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_house.Domain.Services
{
    public class FornecedoresDomain
    {
        public FornecedoresDTO ConsultarFornecedorById(int id)
        {
            FornecedoresRepository fornecedor = new FornecedoresRepository();
            FornecedoresMapper mapper = new FornecedoresMapper();

            return mapper.FornecedoresToDTO(fornecedor.GetFornecedorById(id));
        }

        public Object CriarNovoFornecedor(FornecedoresDTO fornecedoresDTO)
        {
            FornecedoresRepository fornecedor = new FornecedoresRepository();
            FornecedoresMapper mapper = new FornecedoresMapper();

            return fornecedor.CreateNewFornecedor(mapper.DTOToFornecedores(fornecedoresDTO));
        }

        public Object DeletarFornecedor(int id)
        {
            FornecedoresRepository forncedor = new FornecedoresRepository();

            return forncedor.DeleteFornecedor(id);
        }

        public Object AtualizarFornecedor(int id, FornecedoresDTO fornecedoresDTO)
        {
            FornecedoresRepository fornecedor = new FornecedoresRepository();
            FornecedoresMapper mapper = new FornecedoresMapper();

            return fornecedor.UpdateFornecedor(id, mapper.DTOToFornecedores(fornecedoresDTO));
        }
    }
}
