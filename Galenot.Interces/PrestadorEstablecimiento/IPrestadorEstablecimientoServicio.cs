using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galenot.Interces.PrestadorEstablecimiento.DTOs;

namespace Galenot.Interces.PrestadorEstablecimiento
{
    public interface IPrestadorEstablecimientoServicio
    {
        Task<long> Create(PrestadorEstablecimientoDto prestadorEspecialidad);
        Task<IEnumerable<PrestadorEstablecimientoDto>> GetAll();
        Task<PrestadorEstablecimientoDto> GetById(long id);
        Task Update(PrestadorEstablecimientoDto prestadorEspecialidad, long id);
        Task Delete(long id);
    }
}
