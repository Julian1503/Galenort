using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galenort.Dominio.Repositorio;
using Galenort.Mapper;
using Galenot.Interces.DiaHorario;
using Galenot.Interces.DiaHorario.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Galenort.Implementacion.DiaHorario
{
    public class DiaHorarioServicio : IDiaHorarioServicio
    {
        private IRepositorio<Dominio.Entidades.DiaHorario> _repositorio;
        private IMapper _mapper;

        public DiaHorarioServicio(IRepositorio<Dominio.Entidades.DiaHorario> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x=>x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }
        public async Task Create(DiaHorarioDto diaHorario)
        {
            var _diaHorario = _mapper.Map<Dominio.Entidades.DiaHorario>(diaHorario);
            await _repositorio.Create(_diaHorario);
        }

        public async Task<IEnumerable<DiaHorarioDto>> GetAll()
        {
            {
                var result = await _repositorio.GetAll(x => x.OrderBy(y => y.Dia.Id),
                    x => x.Include(y => y.Dia).Include(y => y.HorarioPrestador), false);
                return _mapper.Map<IEnumerable<DiaHorarioDto>>(result);
            }
        }

        public async Task<DiaHorarioDto> GetById(long id)
        {
            var diaHorario = await _repositorio.GetById(id, x => x.Include(y => y.Dia).Include(y => y.HorarioPrestador), false);
            return _mapper.Map<DiaHorarioDto>(diaHorario);
        }

        public async Task Update(DiaHorarioDto diaHorario, long id)
        {
            var _diaHorario = _mapper.Map<Dominio.Entidades.DiaHorario>(diaHorario);
            _diaHorario.Id = id;
            await _repositorio.Update(_diaHorario);
        }
        public async Task Delete(long id)
        {
            var _diaHorario = await _repositorio.GetById(id, null, false);
            await _repositorio.Delete(_diaHorario);
        }
    }
}
