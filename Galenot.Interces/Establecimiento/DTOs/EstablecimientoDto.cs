using System;
using System.Collections.Generic;
using System.Text;

namespace Galenot.Interces.Establecimiento.DTOs
{
   public class EstablecimientoDto :DtoBase
    {
        public string RazonSocial { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Localidad { get; set; }
    }
}
