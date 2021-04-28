using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {

            _usuarioRepository = new UsuarioRepository();

        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_usuarioRepository.ListarTodos());

        }

        [HttpPut]
        public IActionResult Put(int id, Usuario usuarioAtt)
        {

            return StatusCode(200);

        }

    }
}
