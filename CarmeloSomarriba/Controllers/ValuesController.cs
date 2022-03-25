using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

//para reconocer el archivo MyDbContext
using CarmeloSomarriba.Data;
using CarmeloSomarriba.Models;
//para usar el Tolist
using System.Linq;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarmeloSomarriba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly MyDbcontext _context;

        public ValuesController(MyDbcontext context) { _context = context; }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            IEnumerable<Categoria> categoria = _context.Categorias.ToList();
            return categoria;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
