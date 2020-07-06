using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galenor.API.Models
{
    public class HorarioPrestadorModel
    {
        public long IdEstablecimiento { get; set; }
        public long IdEspecialidad { get; set; }
        public long IdPrestador { get; set; }
        public long IdHorario { get; set; }
    }
}
