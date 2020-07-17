using System;
using System.Collections.Generic;
using System.Text;
using Galenot.Interces.DiaHorario.DTOs;
using Galenot.Interces.Especialidad.DTOs;
using Galenot.Interces.Establecimiento.DTOs;
using Galenot.Interces.Prestador.DTOs;
using Galenot.Interces.PrestadorEstablecimiento.DTOs;

namespace Galenot.Interces.HorarioPrestador.DTOs
{
    public class HorarioPrestadorDto : DtoBase
    {
        public long IdPrestadorEstablecimiento { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public IEnumerable<DiaHorarioDto> DiaHorarios { get; set; }
        public PrestadorEstablecimientoDto PrestadorEstablecimiento { get; set; }
    }
}
