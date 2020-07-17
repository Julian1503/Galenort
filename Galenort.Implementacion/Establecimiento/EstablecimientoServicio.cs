using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galenort.Dominio.Repositorio;
using Galenort.Mapper;
using Galenot.Interces.Establecimiento;
using Galenot.Interces.Establecimiento.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Galenort.Implementacion.Establecimiento
{
    public class EstablecimientoServicio : IEstablecimientoServicio
    {
        private IMapper _mapper;

        private IRepositorio<Dominio.Entidades.Establecimiento> _repositorio;

        public EstablecimientoServicio(IRepositorio<Dominio.Entidades.Establecimiento> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x => x.AddProfile<MapperProfile>());
            _mapper = config.CreateMapper();
        }

        public async Task Create(EstablecimientoDto establecimiento)
        {
            var _establecimiento = _mapper.Map<Dominio.Entidades.Establecimiento>(establecimiento);
            await _repositorio.Create(_establecimiento);
        }

        public async Task Delete(long id)
        {
            var _establecimiento = await _repositorio.GetById(id, null, false);
            await _repositorio.Delete(_establecimiento);
        }

        public async Task Update(EstablecimientoDto establecimiento, long id)
        {
            var _establecimiento = _mapper.Map<Dominio.Entidades.Establecimiento>(establecimiento);
            _establecimiento.Id = id;
            await _repositorio.Update(_establecimiento);
        }

        public async Task<EstablecimientoDto> GetById(long id)
        {
            var establecimiento = await _repositorio.GetById(id, null, false);
            return _mapper.Map<EstablecimientoDto>(establecimiento);
        }

        public async Task<IEnumerable<EstablecimientoDto>> ObtenerTodos()
        {
            var result = await _repositorio.GetAll(x => x.OrderBy(y => y.RazonSocial), x=>x.Include(y=>y.Localidad), false);
            return _mapper.Map<IEnumerable<EstablecimientoDto>>(result);
        }

        public async Task Update(long id)
        {
            var _establecimiento = await _repositorio.GetById(id, null, false);
            await _repositorio.Update(_establecimiento);
        }
    }
}
