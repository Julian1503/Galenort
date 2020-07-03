using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class Establecimiento : EntityBase
    {
        public string RazonSocial { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Localidad { get; set; }

        public virtual IEnumerable<PrestadorEstablecimiento> PrestadorEstablecimientos { get; set; }
        public virtual IEnumerable<HorarioPrestador> HorarioPrestadores { get; set; }
    }
}
