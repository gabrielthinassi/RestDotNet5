using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestDotNet5.Model;
using RestDotNet5.Business;

namespace RestDotNet5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("v{version:apiVersion}/api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;

        private IPessoaBusiness _pessoaBusiness;

        public PessoaController(ILogger<PessoaController> logger, IPessoaBusiness pessoaBusiness)
        {
            _logger = logger;
            _pessoaBusiness = pessoaBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pessoaBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var pessoa = _pessoaBusiness.FindByID(id);
            if (pessoa == null) return NotFound();
            return Ok(pessoa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pessoa pessoa)
        {
            if (pessoa == null) return BadRequest();
            return Ok(_pessoaBusiness.Create(pessoa));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Pessoa pessoa)
        {
            if (pessoa == null) return BadRequest();
            return Ok(_pessoaBusiness.Update(pessoa));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _pessoaBusiness.Delete(id);
            return NoContent();
        }
    }
}
