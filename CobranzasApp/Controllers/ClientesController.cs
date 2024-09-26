using CobranzasApp.Models;
using CobranzasApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CobranzasApp.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Clientes>> Get()
        {
            return Ok(_clienteService.GetClientes());
        }

        [HttpGet("{id}")]
        public ActionResult<Clientes> Get(int id)
        {
            var cliente = _clienteService.GetClienteById(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

         // Este método simula la creación de un cliente con datos quemados
        [HttpPost]
        public ActionResult<Clientes> CrearCliente([FromBody] Clientes cliente)
        {
            // Verificar si el cliente recibido es nulo
            if (cliente == null)
            {
                return BadRequest("El cliente no puede ser nulo.");
            }

            // Aquí puedes agregar lógica adicional, como validar datos

            // Datos quemados (hardcoded)
            var nuevoCliente = cliente;
       

            // Devolver el nuevo cliente como respuesta
            return CreatedAtAction(nameof(CrearCliente), nuevoCliente);
        }
    }
}
