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
    }
}
