using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class Horario : EntityBase
    {
        public TimeSpan HoraInicio{ get; set; }
        public TimeSpan HoraFin { get; set; }

       public virtual IEnumerable<DiaHorario> DiaHorarios { get; set; }
       public virtual IEnumerable<HorarioPrestador> HorarioPrestadores { get; set; }
    }
}
