using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galenort.Dominio.Repositorio;
using Galenort.Mapper;
using Galenot.Interces.Prestador;
using Galenot.Interces.Prestador.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Galenort.Implementacion.Prestador
{
    public class PrestadorServicio : IPrestadorServicio
    {
        private IRepositorio<Dominio.Entidades.Prestador> _repositorio;
        private IRepositorio<Dominio.Entidades.PrestadorEspecialidad> _repoEsp;
        private IRepositorio<Dominio.Entidades.PrestadorEstablecimiento> _repoEst;
        private IMapper _mapper;
        public PrestadorServicio(IRepositorio<Dominio.Entidades.Prestador> repositorio)
        {
            var config = new MapperConfiguration(x => x.AddProfile<MapperProfile>());
            _mapper = config.CreateMapper();
            _repositorio = repositorio;
        }

        public async Task<PrestadorDto> GetById(long id)
        {
            var prestador = await _repositorio.GetById(id, null, false);
            return _mapper.Map<PrestadorDto>(prestador);
        }

        public async Task<IEnumerable<PrestadorDto>> ObtenerTodos()
        {
            var result = await _repositorio.GetAll(x => x.OrderBy(y => y.Apellido).OrderBy(y => y.Nombre), null, false);
            return _mapper.Map <IEnumerable<PrestadorDto>>(result);
        }

        public async Task<long> Create(PrestadorDto prestador)
        {
            var _prestador = _mapper.Map<Dominio.Entidades.Prestador>(prestador);
            return await _repositorio.Create(_prestador);
        }

        public async Task Delete(long id)
        {
            var _prestador = await _repositorio.GetById(id,null,false);
            await _repositorio.Delete(_prestador);
        }

        public async Task Update(PrestadorDto prestador,long id)
        {
            var _prestador = _mapper.Map<Dominio.Entidades.Prestador>(prestador);
            _prestador.Id = id;
            await _repositorio.Update(_prestador);
        }
    }
}
