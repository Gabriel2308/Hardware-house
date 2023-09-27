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
    }
}