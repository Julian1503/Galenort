using System.Collections.Generic;

namespace Galenort.Dominio.Entidades
{
    public class Establecimiento : EntityBase
    {
        public string RazonSocial {get; set;}
        public string Direccion { get; set; }
        public long IdLocalidad { get; set; }

        public virtual Localidad Localidad { get; set; }
        public virtual IEnumerable<PrestadorEstablecimiento> PrestadorEstablecimientos { get; set; }
    }
}
