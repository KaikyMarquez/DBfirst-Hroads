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
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {

        private IPersonagensRepository _personagensRepository { get; set; }

        public PersonagensController()
        {

            _personagensRepository = new PersonagensRepository();

        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_personagensRepository.Listar());

        }

    }
}
