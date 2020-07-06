using System;
using Galenort.Dominio.Entidades;
using Galenort.Dominio.Repositorio;
using Galenort.Implementacion.Especialidad;
using Galenort.Implementacion.Establecimiento;
using Galenort.Implementacion.HorarioPrestador;
using Galenort.Implementacion.Prestador;
using Galenort.Infraestructura;
using Galenort.Infraestructura.Repo;
using Galenot.Interces.Especialidad;
using Galenot.Interces.Establecimiento;
using Galenot.Interces.HorarioPrestador;
using Galenot.Interces.Prestador;
using Microsoft.Extensions.DependencyInjection;

namespace Galenort.IoC
{
    public class Inyeccion
    {
        public static void ConfigureService(IServiceCollection service)
        {
            service.AddDbContext<DataContext>();

            service.AddTransient<IEspecialidadServicio, EspecialidadServicio>();
            service.AddTransient<IRepositorio<Especialidad>, Repositorio<Especialidad>>();

            service.AddTransient<IHorarioPrestadorServicio, HorarioPrestadorServicio>();
            service.AddTransient<IRepositorio<HorarioPrestador>, Repositorio<HorarioPrestador>>();

            service.AddTransient<IEstablecimientoServicio, EstablecimientoServicio>();
            service.AddTransient<IRepositorio<Establecimiento>, Repositorio<Establecimiento>>();

            service.AddTransient<IPrestadorServicio, PrestadorServicio>();
            service.AddTransient<IRepositorio<Prestador>, Repositorio<Prestador>>();
        }
    }
}
