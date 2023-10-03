using Hardware_house.Domain.DTO;
using Hardware_house.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_house.Infra.CrossCutting.Mapper
{
    public class FornecedoresMapper
    {
        public FornecedoresDTO FornecedoresToDTO(Fornecedor fornecedor)
        {
            FornecedoresDTO fornecedorDTO = new FornecedoresDTO();

            fornecedorDTO.id= fornecedor.id;
            fornecedorDTO.email = fornecedor.email;
            fornecedorDTO.uf = fornecedor.uf;
            fornecedorDTO.telefone = fornecedor.telefone;
            fornecedorDTO.cnpj = fornecedor.cnpj;
            fornecedorDTO.cidade = fornecedor.cidade;
            fornecedorDTO.nomeEmpresa = fornecedor.nomeEmpresa;

            return fornecedorDTO;
        }


        public Fornecedor DTOToFornecedores(FornecedoresDTO fornecedoresDTO)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.id = fornecedoresDTO.id;
            fornecedor.email = fornecedoresDTO.email;
            fornecedor.uf = fornecedoresDTO.uf;
            fornecedor.cnpj = fornecedoresDTO.cnpj;
            fornecedor.cidade = fornecedoresDTO.cidade;
            fornecedor.nomeEmpresa = fornecedoresDTO.nomeEmpresa;
            fornecedor.telefone = fornecedoresDTO.telefone;

            return fornecedor;
        }
    }
}
