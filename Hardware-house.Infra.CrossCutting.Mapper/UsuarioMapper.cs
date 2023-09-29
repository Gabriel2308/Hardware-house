using Hardware_house.Domain.DTO;
using Hardware_house.Infra.Entities;

namespace Hardware_house.Infra.CrossCutting.Mapper
{
    public class UsuarioMapper
    {
        public UsuarioDTO UsuarioToDTO(Usuario user)
        {
            UsuarioDTO userDto= new UsuarioDTO();

            userDto.cpf = user.Cpf;
            userDto.nome = user.PrimeiroNome;
            userDto.sobrenome = user.Sobrenome;
            userDto.dataNascimento = user.DataNasc;

            return userDto;
        }

        public Usuario DTOToUsuario(UsuarioDTO userDto)
        {
            Usuario user = new Usuario();

            user.Cpf = userDto.cpf;
            user.PrimeiroNome = userDto.nome;
            user.Sobrenome = userDto.sobrenome;
            user.DataNasc = userDto.dataNascimento;

            return user;
        }
    }
}