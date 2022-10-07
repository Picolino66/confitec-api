using ApiConfitec.Application.Dtos;
using ApiConfitec.Application.Interfaces.Mappers;
using ApiConfitec.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace ApiConfitec.Application.Mapper
{ 
    public class MapperUsuario : IMapperUsuario
    {
        IEnumerable<UsuarioDto> usuariosDto = new List<UsuarioDto>();
        public Usuario MapperDtoToEntity(UsuarioDto usuarioDto)
        {
            var usuario = new Usuario()
            {
                Id = usuarioDto.Id,
                Nome = usuarioDto.Nome,
                Sobrenome = usuarioDto.Sobrenome,
                Email = usuarioDto.Email,
                DataNascimento = usuarioDto.DataNascimento,
                Escolaridade = usuarioDto.Escolaridade,
            };
            return usuario;
        }

        public UsuarioDto MapperEntityToDto(Usuario usuario)
        {
            var usuarioDto = new UsuarioDto()
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Sobrenome = usuario.Sobrenome,
                Email = usuario.Email,
                DataNascimento = usuario.DataNascimento,
                Escolaridade = usuario.Escolaridade,
            };
            return usuarioDto;
        }

        public IEnumerable<UsuarioDto> MapperListUsuariosDto(IEnumerable<Usuario> usuarios)
        {
            var dto = usuarios.Select(u =>
                new UsuarioDto
                {
                    Id = u.Id,
                    Nome = u.Nome,
                    Sobrenome = u.Sobrenome,
                    Email = u.Email,
                    DataNascimento = u.DataNascimento,
                    Escolaridade = u.Escolaridade,
                }
            );
            return dto;
        }
    }
}
