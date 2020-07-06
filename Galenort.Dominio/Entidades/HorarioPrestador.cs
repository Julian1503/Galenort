using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class HorarioPrestador : EntityBase
    {
        public long IdPrestador { get; set; }
        public long IdHorario { get; set; }

        public virtual Prestador Prestador { get; set; }
        public virtual Horario Horario { get; set; }
    }
}
