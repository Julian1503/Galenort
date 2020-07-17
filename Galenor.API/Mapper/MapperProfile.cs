using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Galenor.API.Models;
using Galenort.Dominio.Entidades;
using Galenot.Interces.Especialidad.DTOs;
using Galenot.Interces.Establecimiento.DTOs;
using Galenot.Interces.Prestador.DTOs;

namespace Galenor.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<PrestadorModel, PrestadorDto>().ReverseMap();
            CreateMap<EstablecimientoModel, EstablecimientoDto>().ReverseMap();
            CreateMap<EspecialidadModel, EspecialidadDto>().ReverseMap();
        }
    }
}
