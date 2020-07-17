using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class HorarioPrestador : EntityBase
    {
        public long IdPrestadorEstablecimiento { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public virtual PrestadorEstablecimiento PrestadorEstablecimiento { get; set; }
        public virtual IEnumerable<DiaHorario> DiaHorarios { get; set; }

    }
}
