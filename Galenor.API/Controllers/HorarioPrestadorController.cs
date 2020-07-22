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

        /// <summary>
        /// Metodo del API por el cual se tiene acceso a los horarios del prestador dependiendo de los parametros ingresados.
        /// </summary>
        /// <param name="idprestador"></param>
        /// <param name="idestablecimiento"></param>
        /// <param name="idespecialidad"></param>
        /// <returns>Devuelve una respuesta dependiendo del metodo ObtenerPorFiltro, si es nulo devuelve un Codigo 404, Codigo 200 si la respuesta del metodo es satisfactoria, o un error 500 si es que el servidor tiene error.</returns>
        [HttpGet]
        [Route("ObtenerHorarios/{idprestador:long}/{idestablecimiento:long}/{idespecialidad:long}")]
        public async Task<IActionResult> GetHorarioPrestadorFilter(long idprestador, long idestablecimiento, long idespecialidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _horarioPrestadorServicio.ObtenerPorFiltro(idprestador, idestablecimiento, idespecialidad);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        /// <summary>
        /// Metodo del API por el cual se tiene acceso a todos los horarios del prestador dependiendo de los parametros ingresados.
        /// </summary>
        /// <returns>Devuelve una respuesta dependiendo del metodo ObtenerTodos, si es nulo devuelve un Codigo 404, Codigo 200 si la respuesta del metodo es satisfactoria, o un error 500 si es que el servidor tiene error.</returns>

        [HttpGet]
        [Route("ObtenerTodos")]
        public async Task<IActionResult> ObtenerTodos()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _horarioPrestadorServicio.ObtenerTodos();

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        //[HttpPost]
        //[Route("Crear/{idprestador:long}/{idestablecimiento:long}/{idespecialidad:long}")]
        //public async Task<IActionResult> Create(long idprestador, long idestablecimiento, long idespecialidad)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var result = await _horarioPrestadorServicio.Create(idprestador, idestablecimiento, idespecialidad);

        //    if (result == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(result);
        //}
    }
}