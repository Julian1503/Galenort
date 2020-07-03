using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class PrestadorEstablecimiento : EntityBase
    {
        public long IdPrestador { get; set; }
        public long IdEstablecimiento { get; set; }

        public virtual Prestador Prestador { get; set; }
        public virtual Establecimiento Establecimiento { get; set; }
    }
}
