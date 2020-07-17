using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galenort.Dominio.Repositorio;
using Galenort.Mapper;
using Galenot.Interces.Especialidad;
using Galenot.Interces.Especialidad.DTOs;

namespace Galenort.Implementacion.Especialidad
{
    public class EspecialidadServicio : IEspecialidadServicio
    {
        private IRepositorio<Dominio.Entidades.Especialidad> _repositorio;
        private IMapper _mapper;

        public EspecialidadServicio(IRepositorio<Dominio.Entidades.Especialidad> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x => x.AddProfile<MapperProfile>());
            _mapper = config.CreateMapper();
        }

        public async Task<IEnumerable<EspecialidadDto>> ObtenerTodos()
        {
            var result = await _repositorio.GetAll(x => x.OrderBy(y => y.Descripcion), null, false);
            return _mapper.Map<IEnumerable<EspecialidadDto>>(result);
        }

        public async Task<EspecialidadDto> GetById(long id)
        {
            var especialidad = await _repositorio.GetById(id, null, false);
            return _mapper.Map<EspecialidadDto>(especialidad);
        }

        public async Task Create(EspecialidadDto especialidad)
        {
            var _especialidad = _mapper.Map<Dominio.Entidades.Especialidad>(especialidad);
            await _repositorio.Create(_especialidad);
        }

        public async Task Update(EspecialidadDto especialidad,long id)
        {
            var _especialidad = _mapper.Map<Dominio.Entidades.Especialidad>(especialidad);
            _especialidad.Id = id;
            await _repositorio.Update(_especialidad);
        }
        public async Task Delete(long id)
        {
            var _especialidad = await _repositorio.GetById(id, null, false);
            await _repositorio.Delete(_especialidad);
        }

    }
}
