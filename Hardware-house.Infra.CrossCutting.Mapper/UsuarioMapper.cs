using Hardware_house.Domain.DTO;
using Hardware_house.Infra.Entities;

namespace Hardware_house.Infra.CrossCutting.Mapper
{
    public class UsuarioMapper
    {
        public UsuarioDTO UsuarioToDTO(Usuario user)
        {
            UsuarioDTO userDto= new UsuarioDTO();

            userDto.cpf = user.cpf;
            userDto.nome = user.primeiro_nome;
            userDto.sobrenome = user.sobrenome;
            userDto.dataNascimento = user.data_nasc;

            return userDto;
        }

        public Usuario DTOToUsuario(UsuarioDTO userDto)
        {
            Usuario user = new Usuario();

            user.cpf = userDto.cpf;
            user.primeiro_nome = userDto.nome;
            user.sobrenome = userDto.sobrenome;
            user.data_nasc = userDto.dataNascimento;

            return user;
        }
    }
}