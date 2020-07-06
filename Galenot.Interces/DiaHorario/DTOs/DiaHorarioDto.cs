using System;
using System.Collections.Generic;
using System.Text;
using Galenot.Interces.Dia.DTOs;
using Galenot.Interces.Horario.DTOs;

namespace Galenot.Interces.DiaHorario.DTOs
{
    public class DiaHorarioDto : DtoBase
    {
        public long IdDia { get; set; }
        public long IdHorario { get; set; }

        public DiaDto Dia { get; set; }
        public HorarioDto Horario { get; set; }
    }
}
