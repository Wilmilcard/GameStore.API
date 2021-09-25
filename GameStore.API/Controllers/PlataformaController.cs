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
    public class PlataformaController : ControllerBase
    {
        private readonly IPlataformaServices _plataformaService;
        private readonly IConfiguration Configuration;
        private readonly GameStoreDbContext _context;

        public PlataformaController(IPlataformaServices plataformaService, IConfiguration configuration, GameStoreDbContext context)
        {
            _plataformaService = plataformaService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = _plataformaService
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
                var query = _plataformaService
                    .QueryNoTracking()
                    .Where(x => x.PlataformaId == id)
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
        public async Task<IActionResult> Create([FromBody] Plataforma request)
        {
            try
            {
                if (request == null)
                    return BadRequest(new { success = false, error = 400, content = "La informacion que envio esta vacia" });

                Plataforma p = new Plataforma
                {
                    Nombre = request.Nombre,
                    CreatedAt = Utils.Globals.GetFechaActual(),
                    CreatedBy = request.CreatedBy
                };

                await _plataformaService.AddAsync(p);

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
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Plataforma request)
        {
            try
            {

                using (var transaccion = _context.Database.BeginTransaction())
                {
                    var p = _plataformaService.GetByIdAsync(id).Result;
                    if (p != null)
                    {
                        p.PlataformaId = request.PlataformaId;
                        p.Nombre = request.Nombre;
                        p.CreatedAt = request.CreatedAt;
                        p.CreatedBy = request.CreatedBy;
                        p.UpdatedAt = Utils.Globals.GetFechaActual();

                        await _plataformaService.UpdateAsync(p);
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
            var p = _plataformaService.QueryNoTracking().Where(x => x.PlataformaId == id).FirstOrDefault();
            if (p != null)
            {
                try
                {
                    var rpta = _plataformaService.DeleteAsync(p).Result;
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
                    error = "No se encontro Plataforma.",
                    errorCode = 400
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
