using AutoMapper;
using Galenor.API.Mapper;
using Galenor.API.Models;
using Galenot.Interces.Establecimiento;
using Galenot.Interces.Establecimiento.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Galenor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EstablecimientoController : ControllerBase
    {
        private IEstablecimientoServicio _establecimientoServicio;
        private IMapper _mapper;

        public EstablecimientoController(IEstablecimientoServicio establecimientoServicio)
        {
            _establecimientoServicio = establecimientoServicio;
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

            var result = await _establecimientoServicio.ObtenerTodos();

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

            var result = await _establecimientoServicio.GetById(id);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [NonAction]
        [HttpPost]
        [Route("Crear")]
        public async Task<IActionResult> Create(EstablecimientoModel est)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var establecimiento = _mapper.Map<EstablecimientoDto>(est);
            if (establecimiento == null)
            {
                return NotFound();
            }
            try
            {
                await _establecimientoServicio.Create(establecimiento);

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
        public async Task<IActionResult> Update(EstablecimientoModel establecimiento, long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var _establecimiento = _mapper.Map<EstablecimientoDto>(establecimiento);
                await _establecimientoServicio.Update(_establecimiento, id);

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
                await _establecimientoServicio.Delete(id);

            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }

            return Ok("Success");
        }
    }
}