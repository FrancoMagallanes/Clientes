using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using TrabajoMax.Business.Interface;
using TrabajoMax.Models;
using System.Collections.Generic;

namespace TrabajoMax.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteBusiness _clienteBusiness;

        public ClienteController(IClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateCliente(Cliente cliente)
        {
            try
            {
                int response = _clienteBusiness.CreateCliente(cliente);

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            try
            {
                var clientes = _clienteBusiness.FindClientes();

                if (clientes == null)
                    return NotFound();

                return Ok(clientes);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

    }
}
