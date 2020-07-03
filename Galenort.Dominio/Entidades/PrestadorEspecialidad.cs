using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class PrestadorEspecialidad : EntityBase
    {
        public long IdPrestador { get; set; }
        public long IdEspecialidad { get; set; }

        public virtual Prestador Prestador { get; set; }
        public virtual Especialidad Especialidad { get; set; }
    }
}
