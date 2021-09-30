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
    public class JuegoController : ControllerBase
    {
        private readonly IJuegoServices _juegoService;
        private readonly IConfiguration Configuration;
        private readonly GameStoreDbContext _context;

        public JuegoController(IJuegoServices juegoService, IConfiguration configuration, GameStoreDbContext context)
        {
            _juegoService = juegoService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = _juegoService
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
                var query = _juegoService
                    .QueryNoTracking()
                    .Where(x => x.JuegoId == id)
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
        public async Task<IActionResult> Create([FromBody] Juego request)
        {
            try
            {
                using (var transaccion  = _context.Database.BeginTransaction())
                {
                    if (request == null)
                        return BadRequest(new { success = false, error = 400, content = "La informacion que envio esta vacia" });

                    Juego j = new Juego
                    {
                        Nombre = request.Nombre,
                        Lanzamiento = request.Lanzamiento,
                        Precio = request.Precio,
                        Stock = request.Stock,
                        DirectorId = request.DirectorId,
                        CreatedAt = Utils.Globals.GetFechaActual(),
                        CreatedBy = request.CreatedBy
                    };

                    await _juegoService.AddAsync(j);
                    transaccion.Commit();
                }

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
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Juego request)
        {
            try
            {

                using (var transaccion = _context.Database.BeginTransaction())
                {
                    var j = _juegoService.GetByIdAsync(id).Result;
                    if (j != null)
                    {
                        j.JuegoId = request.JuegoId;
                        j.Nombre = request.Nombre;
                        j.Precio = request.Precio;
                        j.Stock = request.Stock;
                        j.Lanzamiento = request.Lanzamiento;
                        j.DirectorId = request.DirectorId;
                        j.CreatedAt = request.CreatedAt;
                        j.CreatedBy = request.CreatedBy;
                        j.UpdatedAt = Utils.Globals.GetFechaActual();

                        await _juegoService.UpdateAsync(j);
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
            var j = _juegoService.QueryNoTracking().Where(x => x.JuegoId == id).FirstOrDefault();
            if (j != null)
            {
                try
                {
                    var rpta = _juegoService.DeleteAsync(j).Result;
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
                    error = "No se encontro Juego.",
                    errorCode = 400
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
