using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class HabilidadeController : ControllerBase
    {

        private IHabilidadeRepository _habilidadesRepository { get; set; }

        public HabilidadeController()
        {
            
            _habilidadesRepository = new HabilidadeRepository();

        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_habilidadesRepository.ListarTodos());

        }

    }
}
