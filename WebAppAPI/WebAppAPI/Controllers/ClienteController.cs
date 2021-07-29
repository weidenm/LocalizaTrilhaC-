using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace WebAppAPI.Controllers
{
    [Route(template:"api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        static List<Cliente> cliente = new List<Cliente>();
        
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> ObterClientes()
        {
            return Ok(cliente.Select(c => c.cpf));
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult CriarCliente(Cliente cliente)
        {
            try
            {
                cliente.add(cliente);
                return CreatedAtAction(nameof(CriarCliente), Guid.NewGuid());
            }
            catch(Exception ex)
            {
                return StatusCode(statusCode: 500, ex.Message);
            }
        }

        
        [HttpDelete]

        public ActionResult Remover(string cpf)
        {
            // var cliente = clientes.Where(p => p.Cpf == cpf).FirstOrDefault();
            var Cliente = cliente.FirstOrDefault(p => p.cpf == cpf);


            if (Cliente == null)
                return NotFound();

            cliente.Remove(Cliente);
            return Ok();
        }


    }
}
