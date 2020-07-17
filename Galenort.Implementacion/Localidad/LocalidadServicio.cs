using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galenort.Dominio.Repositorio;
using Galenort.Mapper;
using Galenot.Interces.Localidad;
using Galenot.Interces.Localidad.DTOs;
using Galenot.Interces.PrestadorEspecialidad.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Galenort.Implementacion.Localidad
{
    public class LocalidadServicio : ILocalidadServicio
    {
        private IRepositorio<Dominio.Entidades.Localidad> _repositorio;
        private IMapper _mapper;

        public LocalidadServicio(IRepositorio<Dominio.Entidades.Localidad> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x=>x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }

        public async Task Create(LocalidadDto localidad)
        {
            var _localidad = _mapper.Map<Dominio.Entidades.Localidad>(localidad);
            await _repositorio.Create(_localidad);
        }

        public async Task<IEnumerable<LocalidadDto>> GetAll()
        {
            var _localidades = await _repositorio.GetAll(x => x.OrderBy(y => y.Descripcion),null, false);
            return _mapper.Map<IEnumerable<LocalidadDto>>(_localidades);
        }

        public async Task<LocalidadDto> GetById(long id)
        {
            var _localidades = await _repositorio.GetById(id,null, false);
            return _mapper.Map<LocalidadDto>(_localidades);
        }

        public async Task Update(LocalidadDto localidad, long id)
        {
            var _localidades = _mapper.Map<Dominio.Entidades.Localidad>(localidad);
            _localidades.Id = id;
            await _repositorio.Update(_localidades);

        }

        public async Task Delete(long id)
        {
            var _localidades = await _repositorio.GetById(id, null, false);
            await _repositorio.Delete(_localidades);
        }
    }
}
