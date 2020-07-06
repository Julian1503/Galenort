using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Galenort.Dominio.Entidades;
using Galenot.Interces.Dia.DTOs;
using Galenot.Interces.DiaHorario.DTOs;
using Galenot.Interces.Especialidad.DTOs;
using Galenot.Interces.Establecimiento.DTOs;
using Galenot.Interces.Horario.DTOs;
using Galenot.Interces.HorarioPrestador.DTOs;
using Galenot.Interces.Prestador.DTOs;
using Galenot.Interces.PrestadorEspecialidad.DTOs;
using Galenot.Interces.PrestadorEstablecimiento.DTOs;

namespace Galenort.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Dia, DiaDto>().ReverseMap();
            CreateMap<DiaHorario, DiaHorarioDto>().ReverseMap();
            CreateMap<Especialidad, EspecialidadDto>().ReverseMap();
            CreateMap<Establecimiento, EstablecimientoDto>().ReverseMap();
            CreateMap<Horario, HorarioDto>().ReverseMap();
            CreateMap<HorarioPrestador, HorarioPrestadorDto>().ReverseMap();
            CreateMap<Prestador, PrestadorDto>().ReverseMap();
            CreateMap<PrestadorEspecialidad, PrestadorEspecialidadDto>().ReverseMap();
            CreateMap<PrestadorEstablecimiento, PrestadorEstablecimientoDto>().ReverseMap();
        }
    }
}
