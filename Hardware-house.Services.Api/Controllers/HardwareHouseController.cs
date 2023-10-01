using Hardware_house.Domain.DTO;
using Hardware_house.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hardware_house.Services.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HardwareHouseController : ControllerBase
    {
        private readonly ILogger<HardwareHouseController> _logger;

        public HardwareHouseController(ILogger<HardwareHouseController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetFornecedorBtId")]
        public Object GetFornecedor(int id)
        {
            FornecedoresDomain fornecedores= new FornecedoresDomain();

            return fornecedores.ConsultarFornecedorById(id);
        }

        [HttpPost("PostNewFornecedor")]
        public Object PostFornecedor(FornecedoresDTO fornecedoresDTO)
        {
            FornecedoresDomain fornecedores = new FornecedoresDomain();

            return fornecedores.CriarNovoFornecedor(fornecedoresDTO);
        }

        [HttpPut("UpdateFornecedor")]
        public Object UpdateFornecedor(int id, FornecedoresDTO fornecedoresDTO)
        {
            FornecedoresDomain fornecedores = new FornecedoresDomain();

            return fornecedores.AtualizarFornecedor(id, fornecedoresDTO);
        }

        [HttpDelete("DeleteFornecedor")]
        public Object DeleteFornecedor(int id)
        {
            FornecedoresDomain fornecedores = new FornecedoresDomain();

            return fornecedores.DeletarFornecedor(id);
        }

        [HttpGet("ConsularServicoById")]
        public ServicoDTO ConsultarServico(int id)
        {
            ServicoDomain servico = new ServicoDomain();

            return servico.ConsultarServicoById(id);
        }

        [HttpPost("CriarNovoServico")]
        public Object ConsultarServico(ServicoDTO servicoDto)
        {
            ServicoDomain servico = new ServicoDomain();

            return servico.CriarNovoServico(servicoDto);
        }
        [HttpPut("EditarServico")]
        public Object EditarServico(ServicoDTO servicoDto, int id)
        {
            ServicoDomain servico = new ServicoDomain();

            return servico.AtualizarServico(servicoDto, id);
        }
        [HttpDelete("DeletarServico")]
        public Object ApagarServico(int id)
        {
            ServicoDomain servico = new ServicoDomain();

            return servico.DeletarServico(id);
        }

        [HttpGet("ConsultarItemById")]
        public ItemDTO ConsultarItem(int id)
        {
            ItemDomain item = new ItemDomain();

            return item.ConsultarItemById(id);
        }
        [HttpPost("CriarNovoItem")]
        public Object CriarItem(ItemDTO itemDTO)
        {
            ItemDomain item = new ItemDomain();

            return item.CriarNovoItem(itemDTO);
        }
        [HttpDelete("DeletarItem")]
        public Object DeletarItem(int id)
        {
            ItemDomain item = new ItemDomain();

            return item.DeletarItem(id);
        }
        [HttpPut("AtualizarItem")]
        public Object Atualizaritem(int id, ItemDTO itemDto)
        {
            ItemDomain item = new ItemDomain();

            return item.EditarItem(id, itemDto);
        }
    }
}