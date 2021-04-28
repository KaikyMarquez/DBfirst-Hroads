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
    public class TipoController : ControllerBase
    {

        private ITipoRepository _tipoRepository { get; set; }

        public TipoController()
        {

            _tipoRepository = new TipoRepository();

        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_tipoRepository.Listar());

        }

    }
}
