using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galenot.Interces.Establecimiento.DTOs;

namespace Galenot.Interces.Establecimiento
{
   public interface IEstablecimientoServicio
   {
       Task<IEnumerable<EstablecimientoDto>> ObtenerTodos();
   }
}
