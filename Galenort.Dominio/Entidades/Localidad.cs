using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class Localidad : EntityBase
    {
        public string Descripcion { get; set; }

        public virtual IEnumerable<Establecimiento> Establecimientos { get; set; }
    }
}
