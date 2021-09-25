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
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaServices _marcaService;
        private readonly IConfiguration Configuration;
        private readonly GameStoreDbContext _context;

        public MarcaController(IMarcaServices marcaService, IConfiguration configuration, GameStoreDbContext context)
        {
            _marcaService = marcaService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = _marcaService
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
                var query = _marcaService
                    .QueryNoTracking()
                    .Where(x => x.MarcaId == id)
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
        public async Task<IActionResult> Create([FromBody] Marca request)
        {
            try
            {
                if (request == null)
                    return BadRequest(new { success = false, error = 400, content = "La informacion que envio esta vacia" });

                Marca m = new Marca
                {
                    Nombre = request.Nombre,
                    CreatedAt = Utils.Globals.GetFechaActual(),
                    CreatedBy = request.CreatedBy
                };

                await _marcaService.AddAsync(m);

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
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Marca request)
        {
            try
            {

                using (var transaccion = _context.Database.BeginTransaction())
                {
                    var m = _marcaService.GetByIdAsync(id).Result;
                    if (m != null)
                    {
                        m.MarcaId = request.MarcaId;
                        m.Nombre = request.Nombre;
                        m.CreatedAt = request.CreatedAt;
                        m.CreatedBy = request.CreatedBy;
                        m.UpdatedAt = Utils.Globals.GetFechaActual();

                        await _marcaService.UpdateAsync(m);
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
            var m = _marcaService.QueryNoTracking().Where(x => x.MarcaId == id).FirstOrDefault();
            if (m != null)
            {
                try
                {
                    var rpta = _marcaService.DeleteAsync(m).Result;
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
                    error = "No se encontro Marca.",
                    errorCode = 400
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
