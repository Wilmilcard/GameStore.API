using GameStore.API.Interfaces;
using GameStore.Domain.DB;
using GameStore.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoServices _estadoService;
        private readonly IConfiguration Configuration;
        private readonly GameStoreDbContext _context;

        public EstadoController(IEstadoServices estadoService, IConfiguration configuration, GameStoreDbContext context)
        {
            _estadoService = estadoService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = _estadoService
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
                var query = _estadoService
                    .QueryNoTracking()
                    .Where(x => x.EstadoId == id)
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
        public async Task<IActionResult> Create([FromBody] Estado request)
        {
            try
            {
                if (request == null)
                    return BadRequest(new { success = false, error = 400, content = "La informacion que envio esta vacia" });

                Estado e = new Estado
                {
                    Nombre = request.Nombre,
                    CreatedAt = Utils.Globals.GetFechaActual(),
                    CreatedBy = request.CreatedBy
                };

                await _estadoService.AddAsync(e);

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
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Estado request)
        {
            try
            {

                using (var transaccion = _context.Database.BeginTransaction())
                {
                    var e = _estadoService.GetByIdAsync(id).Result;
                    if (e != null)
                    {
                        e.EstadoId = request.EstadoId;
                        e.Nombre = request.Nombre;
                        e.CreatedAt = request.CreatedAt;
                        e.CreatedBy = request.CreatedBy;
                        e.UpdatedAt = Utils.Globals.GetFechaActual();

                        await _estadoService.UpdateAsync(e);
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
            var e = _estadoService.QueryNoTracking().Where(x => x.EstadoId == id).FirstOrDefault();
            if (e != null)
            {
                try
                {
                    var rpta = _estadoService.DeleteAsync(e).Result;
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
                    error = "No se encontro Estado.",
                    errorCode = 400
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
