using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galenort.Dominio.Extension;
using Galenort.Dominio.Repositorio;
using Galenort.Mapper;
using Galenot.Interces.HorarioPrestador;
using Galenot.Interces.HorarioPrestador.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Galenort.Implementacion.HorarioPrestador
{
    public class HorarioPrestadorServicio : IHorarioPrestadorServicio
    {
        private IMapper _mapper;
        private IRepositorio<Dominio.Entidades.HorarioPrestador> _repositorio;

        public HorarioPrestadorServicio(IRepositorio<Dominio.Entidades.HorarioPrestador> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x => x.AddProfile<MapperProfile>());
            _mapper = config.CreateMapper();
        }

        public async Task<IEnumerable<HorarioPrestadorDto>> ObtenerTodos()
        {
            var result = await _repositorio.GetAll(x => x.OrderBy(y => y.Prestador.Apellido),
                x => x.Include(y => y.Establecimiento).Include(y => y.Especialidad).Include(y => y.Horario)
                    .Include(y => y.Prestador),true);
            return _mapper.Map<IEnumerable<HorarioPrestadorDto>>(result);
        }

        public async Task<IEnumerable<HorarioPrestadorDto>> ObtenerPorFiltro(long profesionalId, long establecimientoId, long especialidadId)
        {
            Expression<Func<Dominio.Entidades.HorarioPrestador, bool>> exp = x => true;

            if (establecimientoId != 0)
            {
                exp = exp.And(x=> x.IdEstablecimiento == establecimientoId);
            }

            if (profesionalId != 0)
            {
                exp = exp.And(x => x.IdPrestador == profesionalId);
            }

            if (especialidadId != 0)
            {
                exp = exp.And(x => x.IdEspecialidad == especialidadId);
            }

            var result = await _repositorio.GetByFilter(exp, x => x.OrderBy(y => y.Prestador.Apellido),
                x => x.Include(y => y.Establecimiento).Include(y => y.Especialidad).Include(y => y.Horario)
                    .Include(y => y.Prestador), true);
            return _mapper.Map<IEnumerable<HorarioPrestadorDto>>(result);
        }
    }
}
