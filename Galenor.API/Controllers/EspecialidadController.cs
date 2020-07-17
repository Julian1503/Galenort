using AutoMapper;
using Galenor.API.Mapper;
using Galenor.API.Models;
using Galenot.Interces.Especialidad;
using Galenot.Interces.Especialidad.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Galenor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EspecialidadController : ControllerBase
    {
        private IEspecialidadServicio _especialidadServicio;
        private IMapper _mapper;

        public EspecialidadController(IEspecialidadServicio especialidadServicio)
        {
            _especialidadServicio = especialidadServicio;
            var config = new MapperConfiguration(x => x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();

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

        [NonAction]
        [HttpGet]
        [Route("ObtenerPorId/{id:long}")]
        public async Task<IActionResult> GetById(long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _especialidadServicio.GetById(id);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [NonAction]
        [HttpPost]
        [Route("Crear")]
        public async Task<IActionResult> Create(EspecialidadModel est)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var especialidad = _mapper.Map<EspecialidadDto>(est);
            if (especialidad == null)
            {
                return NotFound();
            }
            try
            {
                await _especialidadServicio.Create(especialidad);

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
        public async Task<IActionResult> Update(EspecialidadModel especialidad, long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var _especialidad = _mapper.Map<EspecialidadDto>(especialidad);
                await _especialidadServicio.Update(_especialidad, id);
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
                await _especialidadServicio.Delete(id);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }

            return Ok("Success");
        }
    }
}