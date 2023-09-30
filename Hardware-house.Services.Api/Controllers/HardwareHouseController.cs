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

        [HttpGet("GetUserByCpf")]
        public UsuarioDTO Get(string cpf)
        {
            UsuarioDomain user = new UsuarioDomain();

            return user.ConsultarUsuarioByCpf(cpf);
        }
        [HttpPost("PostNewUser")]

        public object PostUser(UsuarioDTO userDto)
        {
            UsuarioDomain user = new UsuarioDomain();

            return user.CriarNovoUsuario(userDto);
        }
        [HttpDelete("DeleteUser")]
        public object Delete(string cpf)
        {
            UsuarioDomain user = new UsuarioDomain();

            return user.DeletarUsuario(cpf);
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
    }
}