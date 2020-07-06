using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galenot.Interces.Prestador;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Galenor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PrestadorController : ControllerBase
    {
        private IPrestadorServicio _prestadorServicio;
        public PrestadorController(IPrestadorServicio prestadorServicio)
        {
            _prestadorServicio = prestadorServicio;
        }

        [HttpGet]
        [Route("ObtenerTodos")]
        public async Task<IActionResult> ObtenerTodos()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _prestadorServicio.ObtenerTodos();

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}