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
        public long IdEstablecimiento { get; set; }
        public long IdEspecialidad { get; set; }
        public long IdPrestador { get; set; }
        public long IdHorario { get; set; }

        public EstablecimientoDto Establecimiento { get; set; }
        public EspecialidadDto Especialidad { get; set; }
        public PrestadorDto Prestador { get; set; }
        public HorarioDto Horario { get; set; }
    }
}
