﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Galenort.Dominio.Entidades
{
    public class PrestadorEstablecimiento : EntityBase
    {
        public long IdPrestadorEspecialidad { get; set; }
        public long IdEstablecimiento { get; set; }

        public virtual PrestadorEspecialidad PrestadorEspecialidad { get; set; }
        public virtual Establecimiento Establecimiento { get; set; }
        public virtual IEnumerable<HorarioPrestador> HorarioPrestadores { get; set; }
    }
}
