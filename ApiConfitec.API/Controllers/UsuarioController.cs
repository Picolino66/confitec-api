using ApiConfitec.Application.Dtos;
using ApiConfitec.Application.Interfaces;
using ApiConfitec.Domain.Core.Interfaces.Repositorys;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace ApiConfitec.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IApplicationServiceUsuario applicationServiceUsuario;
        private readonly IRepositoryUsuario repositoryUsuario;
        public UsuarioController(IApplicationServiceUsuario applicationServiceUsuario, IRepositoryUsuario repositoryUsuario)
        {
            this.applicationServiceUsuario = applicationServiceUsuario;
            this.repositoryUsuario = repositoryUsuario;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceUsuario.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceUsuario.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] UsuarioDto usuarioDTO)
        {
            try
            {
                if (usuarioDTO == null)
                    return NotFound();

                applicationServiceUsuario.Add(usuarioDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        [HttpPut]
        public ActionResult Put([FromBody] UsuarioDto usuarioDTO)
        {
            try
            {
                if (usuarioDTO == null)
                    return NotFound();

                applicationServiceUsuario.Update(usuarioDTO);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(string id)
        {
            try
            {   
                int idUser = Int32.Parse(id);
                var usuario = applicationServiceUsuario.GetById(idUser);
                repositoryUsuario.DetachLocal(user => user.Id == idUser); //Não aconselhável
                if (usuario == null)
                    return NotFound();

                applicationServiceUsuario.Remove(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
