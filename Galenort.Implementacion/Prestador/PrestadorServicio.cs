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

namespace Galenort.Implementacion.Prestador
{
    public class PrestadorServicio : IPrestadorServicio
    {
        private IRepositorio<Dominio.Entidades.Prestador> _repositorio;
        private IMapper _mapper;
        public PrestadorServicio(IRepositorio<Dominio.Entidades.Prestador> repositorio)
        {
            var config = new MapperConfiguration(x => x.AddProfile<MapperProfile>());
            _mapper = config.CreateMapper();
            _repositorio = repositorio;
        }
        public async Task<IEnumerable<PrestadorDto>> ObtenerTodos()
        {
            var result = await _repositorio.GetAll(x => x.OrderBy(y => y.Apellido).OrderBy(y => y.Nombre), null, false);
            return _mapper.Map <IEnumerable<PrestadorDto>>(result);
        }
    }
}
