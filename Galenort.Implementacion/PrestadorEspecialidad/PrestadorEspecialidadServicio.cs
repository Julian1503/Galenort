using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galenort.Dominio.Repositorio;
using Galenort.Mapper;
using Galenot.Interces.PrestadorEspecialidad;
using Galenot.Interces.PrestadorEspecialidad.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Galenort.Implementacion.PrestadorEspecialidad
{
    public class PrestadorEspecialidadServicio : IPrestadorEspecialidadServicio
    {
        private IRepositorio<Dominio.Entidades.PrestadorEspecialidad> _repositorio;
        private IMapper _mapper;

        public PrestadorEspecialidadServicio(IRepositorio<Dominio.Entidades.PrestadorEspecialidad> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x=>x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }

        public async Task<long> Create(PrestadorEspecialidadDto prestadorEspecialidad)
        {
            var prest = _mapper.Map<Dominio.Entidades.PrestadorEspecialidad>(prestadorEspecialidad);
            return await _repositorio.Create(prest);
        }

        public async Task<IEnumerable<PrestadorEspecialidadDto>> GetAll()
        {
            var presesp = await _repositorio.GetAll(x => x.OrderBy(y => y.Prestador.Apellido),
                x => x.Include(y => y.Especialidad).Include(y => y.Prestador), false);
            return _mapper.Map<IEnumerable<PrestadorEspecialidadDto>>(presesp);
        }

        public async Task<PrestadorEspecialidadDto> GetById(long id)
        {
            var presesp = await _repositorio.GetById(id,
                x => x.Include(y => y.Especialidad).Include(y => y.Prestador), false);
            return _mapper.Map<PrestadorEspecialidadDto>(presesp);
        }

        public async Task Update(PrestadorEspecialidadDto prestadorEspecialidad,long id)
        {
            var _prestadorEspecialidad = _mapper.Map<Dominio.Entidades.PrestadorEspecialidad>(prestadorEspecialidad);
            _prestadorEspecialidad.Id = id;
            await _repositorio.Update(_prestadorEspecialidad);
        }

        public async Task Delete(long id)
        {
            var presesp = await _repositorio.GetById(id,null, false);
            await _repositorio.Delete(presesp);
        }
    }
}
