using Hardware_house.Domain.DTO;
using Hardware_house.Infra.CrossCutting.Mapper;
using Hardware_house.Infra.Data.Repositories;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_house.Domain.Services
{
    public class ServicoDomain
    {
        public ServicoDTO ConsultarServicoById(int id)
        {
            ServicosRepository servicos = new ServicosRepository();
            ServicoMapper mapper = new ServicoMapper();

            return mapper.ServicoToDto(servicos.GetServico(id));
        }

        public Object CriarNovoServico(ServicoDTO servico)
        {
            ServicosRepository servicos = new ServicosRepository();
            ServicoMapper mapper = new ServicoMapper();

            return servicos.PostServico(mapper.DtoToServico(servico));
        }

        public Object DeletarServico(int id)
        {
            ServicosRepository servicos = new ServicosRepository();

            return servicos.DeleteServico(id);
        }

        public Object AtualizarServico(ServicoDTO servico, int id)
        {
            ServicosRepository servicos = new ServicosRepository();
            ServicoMapper mapper = new ServicoMapper();

            return servicos.UpdateServico(id, mapper.DtoToServico(servico));
        }
    }
}
