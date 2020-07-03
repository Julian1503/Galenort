using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class Especialidad : EntityBase
    {
        public string Descripcion { get; set; }
        
        public virtual IEnumerable<PrestadorEspecialidad> PrestadorEspecialidades { get; set; }
       public virtual IEnumerable<HorarioPrestador> HorarioPrestadores { get; set; }
    }
}
