﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galenot.Interces.Establecimiento.DTOs;

namespace Galenot.Interces.Establecimiento
{
   public interface IEstablecimientoServicio
   {
       Task<IEnumerable<EstablecimientoDto>> ObtenerTodos();
       Task<EstablecimientoDto> GetById(long id);
       Task Create(EstablecimientoDto establecimiento);
       Task Delete(long id);
       Task Update(EstablecimientoDto establecimiento,long id);
    }
}
