using System;
using System.Collections.Generic;
using System.Text;
using Galenot.Interces.Localidad.DTOs;

namespace Galenot.Interces.Establecimiento.DTOs
{
   public class EstablecimientoDto :DtoBase
    {
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public LocalidadDto Localidad { get; set; }
    }
}
