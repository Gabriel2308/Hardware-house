using Hardware_house.Domain.DTO;
using Hardware_house.Infra.CrossCutting.Mapper;
using Hardware_house.Infra.Data.Repositories;

namespace Hardware_house.Domain.Services
{
    public class UsuarioDomain
    {
        public UsuarioDTO ConsultarUsuarioByCpf(string cpf)
        {
            UsuarioRepository user = new UsuarioRepository();
            UsuarioMapper mapper = new UsuarioMapper();
            UsuarioDTO userDto = new UsuarioDTO();

            userDto = mapper.UsuarioToDTO(user.GetUsuarioByCpf(cpf));

            return userDto;
        }

        public object CriarNovoUsuario(UsuarioDTO usuario)
        {
            UsuarioMapper mapper = new UsuarioMapper();
            UsuarioRepository user = new UsuarioRepository();

            var createUser = user.CreateUsuario(mapper.DTOToUsuario(usuario));

            return createUser;
        }

        public Object DeletarUsuario(string cpf)
        {
            UsuarioRepository user = new UsuarioRepository();

            var deleteUser = user.DeleteUsuarioByCpf(cpf);

            return deleteUser;
        }

    }
}