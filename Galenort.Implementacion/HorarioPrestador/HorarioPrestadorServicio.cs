﻿using System;
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
            var result = await _repositorio.GetAll(null,
                x => x.Include(y => y.PrestadorEstablecimiento.Establecimiento)
                    .Include(y => y.PrestadorEstablecimiento.PrestadorEspecialidad.Especialidad)
                    .Include(y=>y.PrestadorEstablecimiento.Establecimiento.Localidad)
                    .Include(y => y.PrestadorEstablecimiento.PrestadorEspecialidad.Prestador)
                    .Include(y=>y.DiaHorarios)
                    .ThenInclude(y=>y.Dia),false);
            return _mapper.Map<IEnumerable<HorarioPrestadorDto>>(result);
        }

        public async Task<IEnumerable<HorarioPrestadorDto>> ObtenerPorFiltro(long profesionalId, long establecimientoId, long especialidadId)
        {
            Expression<Func<Dominio.Entidades.HorarioPrestador, bool>> exp = x => true;

            if (establecimientoId != 0)
            {
                exp = exp.And(x=> x.PrestadorEstablecimiento.IdEstablecimiento == establecimientoId);
            }

            if (profesionalId != 0)
            {
                exp = exp.And(x => x.PrestadorEstablecimiento.PrestadorEspecialidad.IdPrestador == profesionalId);
            }

            if (especialidadId != 0)
            {
                exp = exp.And(x => x.PrestadorEstablecimiento.PrestadorEspecialidad.IdEspecialidad == especialidadId);
            }

            var result = await _repositorio.GetByFilter(exp, null,
                x => x.Include(y => y.PrestadorEstablecimiento.Establecimiento).
                    Include(y => y.PrestadorEstablecimiento.Establecimiento.Localidad)
                    .Include(y => y.PrestadorEstablecimiento.PrestadorEspecialidad.Especialidad)
                    .Include(y => y.PrestadorEstablecimiento.PrestadorEspecialidad.Prestador)
                    .Include(y => y.DiaHorarios)
                    .ThenInclude(y => y.Dia), false);
            return _mapper.Map<IEnumerable<HorarioPrestadorDto>>(result);
        }
    }
}
