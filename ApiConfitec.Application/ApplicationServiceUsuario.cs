using ApiConfitec.Application.Dtos;
using ApiConfitec.Application.Interfaces;
using ApiConfitec.Application.Interfaces.Mappers;
using ApiConfitec.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiConfitec.Application
{
    public class ApplicationServiceUsuario : IApplicationServiceUsuario
    {
        private readonly IServiceUsuario serviceUsuario;
        private readonly IMapperUsuario mapperUsuario;
        public ApplicationServiceUsuario (IServiceUsuario serviceUsuario, IMapperUsuario mapperUsuario)
        {
            this.serviceUsuario = serviceUsuario;
            this.mapperUsuario = mapperUsuario;
        }
        public void Add(UsuarioDto usuarioDto)
        {
            var usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
            serviceUsuario.Add(usuario);
        }

        public IEnumerable<UsuarioDto> GetAll()
        {
            var usuarios = serviceUsuario.GetAll();
            var usuariosDto = mapperUsuario.MapperListUsuariosDto(usuarios);
            return usuariosDto;

        }

        public UsuarioDto GetById(int id)
        {
            var usuario = serviceUsuario.GetById(id);
            if(usuario == null)
            {
                return null;
            }
            var usuarioDto = mapperUsuario.MapperEntityToDto(usuario);
            return usuarioDto;
        }

        public void Remove(UsuarioDto usuarioDto)
        {
            var usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
            serviceUsuario.Remove(usuario);
        }

        public void Update(UsuarioDto usuarioDto)
        {
            var usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
            serviceUsuario.Update(usuario);
        }
    }
}
