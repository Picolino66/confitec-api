using ApiConfitec.Application.Dtos;
using ApiConfitec.Domain.Entitys;
using System.Collections.Generic;

namespace ApiConfitec.Application.Interfaces.Mappers
{
    public interface IMapperUsuario
    {
        Usuario MapperDtoToEntity(UsuarioDto usuarioDto);
        IEnumerable<UsuarioDto> MapperListUsuariosDto(IEnumerable<Usuario> usuarios);
        UsuarioDto MapperEntityToDto(Usuario usuario);
    }
}