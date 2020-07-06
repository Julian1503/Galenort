using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galenot.Interces.HorarioPrestador;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Galenor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class HorarioPrestadorController : ControllerBase
    {
        private IHorarioPrestadorServicio _horarioPrestadorServicio;

        public HorarioPrestadorController(IHorarioPrestadorServicio horarioPrestadorServicio)
        {
            _horarioPrestadorServicio = horarioPrestadorServicio;
        }

        [HttpGet]
        [Route("ObtenerHorarios/{idprestador:long}/{idestablecimiento:long}/{idespecialidad:long}")]
        public IActionResult GetHorarioPrestadorFilter(long idprestador, long idestablecimiento, long idespecialidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _horarioPrestadorServicio.ObtenerPorFiltro(idprestador, idespecialidad, idprestador);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("ObtenerTodos")]
        public IActionResult ObtenerTodos()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _horarioPrestadorServicio.ObtenerTodos();

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}