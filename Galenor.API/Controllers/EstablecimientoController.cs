using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galenot.Interces.Establecimiento;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Galenor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EstablecimientoController : ControllerBase
    {
        private IEstablecimientoServicio _establecimientoServicio;
        public EstablecimientoController(IEstablecimientoServicio establecimientoServicio)
        {
            _establecimientoServicio = establecimientoServicio;
        }
        [HttpGet]
        [Route("ObtenerTodos")]
        public async Task<IActionResult> ObtenerTodos()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _establecimientoServicio.ObtenerTodos();

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}