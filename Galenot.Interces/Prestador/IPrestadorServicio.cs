using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galenot.Interces.Prestador.DTOs;

namespace Galenot.Interces.Prestador
{
    public interface IPrestadorServicio
    {
        Task<IEnumerable<PrestadorDto>> ObtenerTodos();
        Task<PrestadorDto> GetById(long id);
        Task<long> Create(PrestadorDto prestador);
        Task Delete(long id);
        Task Update(PrestadorDto prestador,long id);
    }
}
