using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galenot.Interces.DiaHorario.DTOs;

namespace Galenot.Interces.DiaHorario
{
    public interface IDiaHorarioServicio
    {
        Task Create(DiaHorarioDto diaHorario);
        Task<IEnumerable<DiaHorarioDto>> GetAll();
        Task<DiaHorarioDto> GetById(long id);
        Task Update(DiaHorarioDto diaHorario, long id);
        Task Delete(long id);
    }
}
