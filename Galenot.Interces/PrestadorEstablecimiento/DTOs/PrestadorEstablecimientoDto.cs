using System;
using System.Collections.Generic;
using System.Text;
using Galenot.Interces.Establecimiento.DTOs;
using Galenot.Interces.Prestador.DTOs;

namespace Galenot.Interces.PrestadorEstablecimiento.DTOs
{
    public class PrestadorEstablecimientoDto : DtoBase
    {
        public long IdPrestador { get; set; }
        public long IdEstablecimiento { get; set; }

        public PrestadorDto Prestador { get; set; }
        public  EstablecimientoDto Establecimiento { get; set; }
    }
}
