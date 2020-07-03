﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Galenort.Constantes;

namespace Galenort.Dominio.Entidades
{
    public class Horario : EntityBase
    {
        public TimeSpan HoraIncio{ get; set; }
        public TimeSpan HoraFin { get; set; }

       public virtual IEnumerable<DiaHorario> DiaHorarios { get; set; }
       public virtual IEnumerable<HorarioPrestador> HorarioPrestadores { get; set; }
    }
}
