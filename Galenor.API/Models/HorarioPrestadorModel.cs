using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galenor.API.Models
{
    public class HorarioPrestadorModel
    {
        public long IdPrestadorEstablecimiento { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
