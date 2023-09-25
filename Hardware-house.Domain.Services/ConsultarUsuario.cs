using Hardware_house.Domain.DTO;
using Hardware_house.Infra.CrossCutting.Mapper;
using Hardware_house.Infra.Data.Repositories;

namespace Hardware_house.Domain.Services
{
    public class ConsultarUsuario
    {
        public UsuarioDTO ConsultarUsuarioByCpf(string cpf)
        {
            UsuarioRepository user = new UsuarioRepository();
            UsuarioMapper mapper = new UsuarioMapper();
            UsuarioDTO userDto = new UsuarioDTO();

            userDto = mapper.UsuarioToDTO(user.GetUsuarioByCpf(cpf));

            return userDto;
        }

    }
}