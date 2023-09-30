using Hardware_house.Domain.DTO;
using Hardware_house.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_house.Infra.CrossCutting.Mapper
{
    public class ServicoMapper
    {
        public Servico DtoToServico(ServicoDTO servicoDTO)
        {
            Servico servico= new Servico();

            servico.Id = servicoDTO.id;
            servico.Nome = servicoDTO.name;
            servico.Tipo = servicoDTO.tipo;

            return servico;
        }
        public ServicoDTO ServicoToDto(Servico servico)
        {
            ServicoDTO servicoDto = new ServicoDTO();

            servicoDto.id = servico.Id;
            servicoDto.name = servico.Nome;
            servicoDto.tipo = servico.Tipo;

            return servicoDto;
        }
    }
}
