using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class Prestador :EntityBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual IEnumerable<PrestadorEstablecimiento> PrestadorEstablecimientos { get; set; }
       public virtual IEnumerable<HorarioPrestador> HorarioPrestadores { get; set; }
        public virtual IEnumerable<PrestadorEspecialidad> PrestadorEspecialidades { get; set; }
    }

}
