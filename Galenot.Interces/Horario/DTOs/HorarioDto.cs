using System;
using System.Collections.Generic;
using System.Text;

namespace Galenot.Interces.Horario.DTOs
{
   public class HorarioDto  : DtoBase
    {
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
