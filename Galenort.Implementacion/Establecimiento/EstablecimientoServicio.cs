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

        public async Task<IEnumerable<EstablecimientoDto>> ObtenerTodos()
        {
            var result = await _repositorio.GetAll(x => x.OrderBy(y => y.RazonSocial), null, false);
            return _mapper.Map<IEnumerable<EstablecimientoDto>>(result);
        }
    }
}
