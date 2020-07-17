using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galenort.Dominio.Repositorio;
using Galenort.Mapper;
using Galenot.Interces.PrestadorEstablecimiento;
using Galenot.Interces.PrestadorEstablecimiento.DTOs;
using Galenot.Interces.PrestadorEstablecimiento;
using Microsoft.EntityFrameworkCore;

namespace Galenort.Implementacion.PrestadorEstablecimiento
{
    public class PrestadorEstablecimientoServicio : IPrestadorEstablecimientoServicio
    {
        private IRepositorio<Dominio.Entidades.PrestadorEstablecimiento> _repositorio;
        private IMapper _mapper;

        public PrestadorEstablecimientoServicio(IRepositorio<Dominio.Entidades.PrestadorEstablecimiento> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x=>x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }
        public async Task<long> Create(PrestadorEstablecimientoDto prestadorEstablecimiento)
        {
            var _prestadorEstablecimiento = _mapper.Map<Dominio.Entidades.PrestadorEstablecimiento>(prestadorEstablecimiento);
            return await _repositorio.Create(_prestadorEstablecimiento);
        }

        public async Task<IEnumerable<PrestadorEstablecimientoDto>> GetAll()
        {
            var _prestadorEstablecimientoes = await _repositorio.GetAll(x => x.OrderBy(y => y.PrestadorEspecialidad.Prestador.Apellido),
                x => x.Include(y => y.Establecimiento).Include(y => y.PrestadorEspecialidad), false);
            return _mapper.Map<IEnumerable<PrestadorEstablecimientoDto>>(_prestadorEstablecimientoes);
        }

        public async Task<PrestadorEstablecimientoDto> GetById(long id)
        {
            var _prestadorEstablecimiento = await _repositorio.GetById(id,
                x => x.Include(y => y.Establecimiento).Include(y => y.PrestadorEspecialidad), false);
            return _mapper.Map<PrestadorEstablecimientoDto>(_prestadorEstablecimiento);
        }

        public async Task Update(PrestadorEstablecimientoDto prestadorEstablecimiento, long id)
        {
            var _prestadorEstablecimiento  = _mapper.Map<Dominio.Entidades.PrestadorEstablecimiento>(prestadorEstablecimiento);
            _prestadorEstablecimiento.Id = id;
            await _repositorio.Update(_prestadorEstablecimiento);

        }

        public async Task Delete(long id)
        {
            var _prestadorEstablecimiento = await _repositorio.GetById(id,null, false);
            await _repositorio.Delete(_prestadorEstablecimiento);
        }
    }
}
