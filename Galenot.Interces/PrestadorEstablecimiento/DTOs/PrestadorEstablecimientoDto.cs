using System;
using System.Collections.Generic;
using System.Text;
using Galenot.Interces.Establecimiento.DTOs;
using Galenot.Interces.Prestador.DTOs;
using Galenot.Interces.PrestadorEspecialidad.DTOs;

namespace Galenot.Interces.PrestadorEstablecimiento.DTOs
{
    public class PrestadorEstablecimientoDto : DtoBase
    {
        public long IdPrestadorEspecialidad { get; set; }
        public long IdEstablecimiento { get; set; }
        public PrestadorEspecialidadDto PrestadorEspecialidad { get; set; }
        public EstablecimientoDto Establecimiento { get; set; }
    }
}
