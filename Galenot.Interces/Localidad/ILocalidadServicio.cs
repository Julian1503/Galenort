using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galenot.Interces.Localidad.DTOs;
using Galenot.Interces.PrestadorEstablecimiento.DTOs;

namespace Galenot.Interces.Localidad
{
    public interface ILocalidadServicio
    {
        Task Create(LocalidadDto localidad);
        Task<IEnumerable<LocalidadDto>> GetAll();
        Task<LocalidadDto> GetById(long id);
        Task Update(LocalidadDto localidad, long id);
        Task Delete(long id);
    }
}
