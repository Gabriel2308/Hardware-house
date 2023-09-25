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
        public object Get(string cpf)
        {
            ConsultarUsuario user = new ConsultarUsuario();

            return user.ConsultarUsuarioByCpf(cpf);
        }
    }
}