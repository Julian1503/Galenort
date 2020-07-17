using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class DiaHorario : EntityBase
    {
        public long IdDia { get; set; }
        public long IdHorarioPrestador { get; set; }

        public virtual Dia Dia { get; set; }
        public virtual HorarioPrestador HorarioPrestador { get; set; }
    }
}
