using AutoMapper;
using Galenor.API.Mapper;
using Galenor.API.Models;
using Galenot.Interces.Prestador;
using Galenot.Interces.Prestador.DTOs;
using Galenot.Interces.PrestadorEspecialidad;
using Galenot.Interces.PrestadorEspecialidad.DTOs;
using Galenot.Interces.PrestadorEstablecimiento;
using Galenot.Interces.PrestadorEstablecimiento.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Galenor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PrestadorController : ControllerBase
    {
        private IPrestadorServicio _prestadorServicio;
        private IPrestadorEspecialidadServicio _prestadorEspecialidadServicio;
        private IPrestadorEstablecimientoServicio _prestadorEstablecimientoServicio;
        private IMapper _mapper;
        public PrestadorController(IPrestadorServicio prestadorServicio,
            IPrestadorEspecialidadServicio prestadorEspecialidadServicio,
            IPrestadorEstablecimientoServicio prestadorEstablecimientoServicio)
        {
            _prestadorServicio = prestadorServicio;
            _prestadorEstablecimientoServicio = prestadorEstablecimientoServicio;
            _prestadorEspecialidadServicio = prestadorEspecialidadServicio;
            var config = new MapperConfiguration(x => x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
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

        [NonAction]
        [HttpGet]
        [Route("ObtenerPorId/{id:long}")]
        public async Task<IActionResult> GetById(long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _prestadorServicio.GetById(id);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [NonAction]
        [HttpPost]
        [Route("Crear")]
        public async Task<IActionResult> Create(PrestadorModel entidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var _prestador = _mapper.Map<PrestadorDto>(entidad);

            if (_prestador == null)
            {
                return NotFound();
            }
            try
            {
                await _prestadorServicio.Create(_prestador);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }

            return Ok("Success");
        }

        [HttpPost]
        [Route("Crear/{idespecialidad:long}/{idestablecimiento:long}")]
        public async Task<IActionResult> Create(PrestadorModel entidad, long idespecialidad, long idestablecimiento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var _prestador = _mapper.Map<PrestadorDto>(entidad);

            if (_prestador == null)
            {
                return NotFound();
            }

            try
            {
                var idprestador = await _prestadorServicio.Create(_prestador);

                var idpresest = await _prestadorEspecialidadServicio.Create(new PrestadorEspecialidadDto
                { IdEspecialidad = idespecialidad, IdPrestador = idprestador });

                await _prestadorEstablecimientoServicio.Create(new PrestadorEstablecimientoDto
                { IdPrestadorEspecialidad = idpresest, IdEstablecimiento = idestablecimiento });

            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
            return Ok("Success");
        }

        [NonAction]
        [HttpPut]
        [Route("Actualizar/{id:long}")]
        public async Task<IActionResult> Update(PrestadorModel prestador, long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var _prestador = _mapper.Map<PrestadorDto>(prestador);
                await _prestadorServicio.Update(_prestador, id);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
            return Ok("Success");
        }

        [NonAction]
        [HttpDelete]
        [Route("Borrar/{id:long}")]
        public async Task<IActionResult> Delete(long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _prestadorServicio.Delete(id);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
            return Ok("Success");
        }
    }
}