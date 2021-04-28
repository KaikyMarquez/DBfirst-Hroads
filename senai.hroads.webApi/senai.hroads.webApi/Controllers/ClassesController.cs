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
    public class ClassesController : ControllerBase
    {

        private IClasseRepository  _classesRepository { get; set; }

        public ClassesController()
        {
            _classesRepository = new ClassesRepository();
        }


        //Funcionando OK
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_classesRepository.Listar());

        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {

            return Ok(_classesRepository.BuscarPorID(id));

        }

        [HttpPut]
        public IActionResult Put(int id, Classes classeAtt)
        {

            _classesRepository.Atualizar(id, classeAtt);

            return StatusCode(200);

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {

            _classesRepository.Deletar(id);

            return StatusCode(204);

        }

        [HttpPost]
        public IActionResult Create(Classes newClass)
        {

            Created(_classesRepository.Cadastar(newClass));

            return StatusCode(201);

        }



    }
}
