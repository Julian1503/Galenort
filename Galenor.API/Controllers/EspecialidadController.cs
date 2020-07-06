using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galenot.Interces.Especialidad;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Galenor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EspecialidadController : ControllerBase
    {
        private IEspecialidadServicio _especialidadServicio;

        public EspecialidadController(IEspecialidadServicio especialidadServicio)
        {
            _especialidadServicio = especialidadServicio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ObtenerTodos")]
        public async Task<IActionResult> ObtenerTodos()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _especialidadServicio.ObtenerTodos();

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}