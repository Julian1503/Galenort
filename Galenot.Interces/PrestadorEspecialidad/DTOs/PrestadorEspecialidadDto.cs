using System;
using System.Collections.Generic;
using System.Text;
using Galenot.Interces.Especialidad.DTOs;
using Galenot.Interces.Prestador.DTOs;

namespace Galenot.Interces.PrestadorEspecialidad.DTOs
{
   public class PrestadorEspecialidadDto : DtoBase
    {
        public long IdPrestador { get; set; }
        public long IdEspecialidad { get; set; }

        public PrestadorDto Prestador { get; set; }
        public EspecialidadDto Especialidad { get; set; }
    }
}
