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
    public class ProtagonistaController : ControllerBase
    {
        private readonly IProtagonistaServices _protagonistaService;
        private readonly IConfiguration Configuration;
        private readonly GameStoreDbContext _context;

        public ProtagonistaController(IProtagonistaServices protagonistaService, IConfiguration configuration, GameStoreDbContext context)
        {
            _protagonistaService = protagonistaService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = _protagonistaService
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
                var query = _protagonistaService
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
        public async Task<IActionResult> Create([FromBody] Protagonista request)
        {
            try
            {
                if (request == null)
                    return BadRequest(new { success = false, error = 400, content = "La informacion que envio esta vacia" });

                Protagonista p = new Protagonista
                {
                    Nombre = request.Nombre,
                    CreatedAt = Utils.Globals.GetFechaActual(),
                    CreatedBy = request.CreatedBy
                };

                await _protagonistaService.AddAsync(p);

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
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Protagonista request)
        {
            try
            {

                using (var transaccion = _context.Database.BeginTransaction())
                {
                    var p = _protagonistaService.GetByIdAsync(id).Result;
                    if (p != null)
                    {
                        p.Id = request.Id;
                        p.Nombre = request.Nombre;
                        p.CreatedAt = request.CreatedAt;
                        p.CreatedBy = request.CreatedBy;
                        p.UpdatedAt = Utils.Globals.GetFechaActual();

                        await _protagonistaService.UpdateAsync(p);
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
            var p = _protagonistaService.QueryNoTracking().Where(x => x.Id == id).FirstOrDefault();
            if (p != null)
            {
                try
                {
                    var rpta = _protagonistaService.DeleteAsync(p).Result;
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
                    error = "No se encontro Protagonista.",
                    errorCode = 400
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
