using System;
using System.Collections.Generic;
using System.Text;
using Galenot.Interces.Especialidad.DTOs;
using Galenot.Interces.Establecimiento.DTOs;
using Galenot.Interces.Horario.DTOs;
using Galenot.Interces.Prestador.DTOs;

namespace Galenot.Interces.HorarioPrestador.DTOs
{
    public class HorarioPrestadorDto : DtoBase
    {
        public long IdPrestador { get; set; }
        public long IdHorario { get; set; }

        public PrestadorDto Prestador { get; set; }
        public HorarioDto Horario { get; set; }
    }
}
