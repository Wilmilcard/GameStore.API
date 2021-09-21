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
    public class AlquilerController : ControllerBase
    {
        private readonly IAlquilerServices _alquilerService;
        private readonly IConfiguration Configuration;
        private readonly GameStoreDbContext _context;

        public AlquilerController(IAlquilerServices alquilerService, IConfiguration configuration, GameStoreDbContext context)
        {
            _alquilerService = alquilerService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = _alquilerService
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
                var query = _alquilerService
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
        public async Task<IActionResult> Create([FromBody] Alquiler request)
        {
            try
            {
                if (request == null)
                    return BadRequest(new { success = false, error = 400, content = "La informacion que envio esta vacia" });

                Alquiler a = new Alquiler
                {
                    Id_Cliente = request.Id_Cliente,
                    Id_Estado = request.Id_Estado,
                    Fecha_Devolucion = request.Fecha_Devolucion,
                    Fecha_Reservacion = request.Fecha_Reservacion,
                    Valor_Total = request.Valor_Total,
                    CreatedAt = Utils.Globals.GetFechaActual(),
                    CreatedBy = request.CreatedBy
                };

                await _alquilerService.AddAsync(a);

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
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Alquiler request)
        {
            try
            {

                using (var transaccion = _context.Database.BeginTransaction())
                {
                    var a = _alquilerService.GetByIdAsync(id).Result;
                    if (a != null)
                    {
                        a.Id = request.Id;
                        a.Id_Cliente = request.Id_Cliente;
                        a.Id_Estado = request.Id_Estado;
                        a.Fecha_Devolucion = request.Fecha_Devolucion;
                        a.Fecha_Reservacion = request.Fecha_Reservacion;
                        a.Valor_Total = request.Valor_Total;
                        a.CreatedAt = request.CreatedAt;
                        a.CreatedBy = request.CreatedBy;
                        a.UpdatedAt = Utils.Globals.GetFechaActual();

                        await _alquilerService.UpdateAsync(a);
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
            var a = _alquilerService.QueryNoTracking().Where(x => x.Id == id).FirstOrDefault();
            if (a != null)
            {
                try
                {
                    var rpta = _alquilerService.DeleteAsync(a).Result;
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
                    error = "No se encontro Alquiler.",
                    errorCode = 400
                };
                return new BadRequestObjectResult(response);
            }
        }

    }
}
