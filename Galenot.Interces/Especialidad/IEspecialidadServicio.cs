using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galenot.Interces.Especialidad.DTOs;

namespace Galenot.Interces.Especialidad
{
    public interface IEspecialidadServicio
    {
        Task<IEnumerable<EspecialidadDto>> ObtenerTodos();
        Task<EspecialidadDto> GetById(long id);
        Task Create(EspecialidadDto especialidad);
        Task Delete(long id);
        Task Update(EspecialidadDto especialidad,long id);
    }
}
