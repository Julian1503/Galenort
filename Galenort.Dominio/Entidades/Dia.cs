using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class Dia : EntityBase
    {
        public string Descripcion { get; set; }

        public virtual IEnumerable<DiaHorario> DiaHorarios { get; set; }
    }
}
