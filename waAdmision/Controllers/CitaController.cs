﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace waAdmision.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {

        // GET: api/<CitaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value11", "value2" };
        }

        // GET api/<CitaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Hola como estas";
        }


        // GET api/<CitaController>/5
        [HttpGet("{idRegistro}")]
        public string GetForm(int idRegistro)
        {
            return "Hola como estas";
        }


        // POST api/<CitaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CitaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CitaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //Hola como estas
        }
    }
}
