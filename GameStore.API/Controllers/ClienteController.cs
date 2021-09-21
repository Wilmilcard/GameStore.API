using GameStore.API.Interfaces;
using GameStore.Domain.DB;
using GameStore.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServices _clienteService;
        private readonly IConfiguration Configuration;
        private readonly GameStoreDbContext _context;

        public ClienteController(IClienteServices clienteService, IConfiguration configuration, GameStoreDbContext context)
        {
            _clienteService = clienteService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = _clienteService
                    .QueryNoTracking();

                var response = new
                {
                    success = true,
                    data = query,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID([FromRoute] int id)
        {
            try
            {
                var query = _clienteService
                    .QueryNoTracking()
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                var response = new
                {
                    success = true,
                    data = query
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] Cliente request)
        {
            try
            {
                if (request == null)
                    return BadRequest(new { success = false, error = 400, content = "La informacion que envio esta vacia" });

                Cliente c = new Cliente
                {
                    Nombre = request.Nombre,
                    Apellido = request.Apellido,
                    NombreCompleto = request.NombreCompleto,
                    Email = request.Email,
                    Nit = request.Nit,
                    Telefono = request.Telefono,
                    Nacimiento = request.Nacimiento,
                    CreatedAt = Utils.Globals.GetFechaActual(),
                    CreatedBy = request.CreatedBy
                };

                await _clienteService.AddAsync(c);

                var response = new
                {
                    success = true,
                    data = request
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Cliente request)
        {
            try
            {

                using (var transaccion = _context.Database.BeginTransaction())
                {
                    var c = _clienteService.GetByIdAsync(id).Result;
                    if (c != null)
                    {
                        c.Id = request.Id;
                        c.Nombre = request.Nombre;
                        c.Apellido = request.Apellido;
                        c.NombreCompleto = request.NombreCompleto;
                        c.Email = request.Email;
                        c.Nit = request.Nit;
                        c.Telefono = request.Telefono;
                        c.Nacimiento = request.Nacimiento;
                        c.CreatedAt = request.CreatedAt;
                        c.CreatedBy = request.CreatedBy;
                        c.UpdatedAt = Utils.Globals.GetFechaActual();

                        await _clienteService.UpdateAsync(c);
                        _context.SaveChanges();
                        transaccion.Commit();
                    }
                }

                var response = new
                {
                    success = true
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var c = _clienteService.QueryNoTracking().Where(x => x.Id == id).FirstOrDefault();
            if (c != null)
            {
                try
                {
                    var rpta = _clienteService.DeleteAsync(c).Result;
                    var response = new
                    {
                        success = true
                    };
                    return new OkObjectResult(response);
                }
                catch (Exception ex)
                {
                    var response = new
                    {
                        success = false,
                        error = ex.Message,
                        errorCode = ex.HResult
                    };
                    return new BadRequestObjectResult(response);
                }
            }
            else
            {
                var response = new
                {
                    success = false,
                    error = "No se encontro Cliente.",
                    errorCode = 400
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
