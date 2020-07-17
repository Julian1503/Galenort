using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galenort.Dominio.Metadata
{
    public class HorarioPrestadorMetadata : IEntityTypeConfiguration<HorarioPrestador>
    {
        public void Configure(EntityTypeBuilder<HorarioPrestador> builder)
        {
            builder.Property(x => x.IdPrestadorEstablecimiento)
                .IsRequired();

            builder.Property(x => x.HoraFin)
                .HasColumnType("Time")
                .IsRequired();

            builder.Property(x => x.HoraInicio)
                .HasColumnType("Time")
                .IsRequired();

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }

        private IEnumerable<HorarioPrestador> Seed()
        {
           return new List<HorarioPrestador>
           {
               new HorarioPrestador
               {
                   Id=1,
                   IdPrestadorEstablecimiento = 1,
                   HoraInicio = new TimeSpan(19,30,0),
                   HoraFin = new TimeSpan(21,0,0)
               },
               new HorarioPrestador
               {
                   Id=2,
                   IdPrestadorEstablecimiento = 2,
                   HoraInicio = new TimeSpan(9,0,0),
                   HoraFin = new TimeSpan(11,0,0)
               },
               new HorarioPrestador
               {
                   Id=3,
                   IdPrestadorEstablecimiento = 3,
                   HoraInicio = new TimeSpan(18,0,0),
                   HoraFin = new TimeSpan(21,0,0)
               },
               new HorarioPrestador
               {
                   Id=4,
                   IdPrestadorEstablecimiento = 3,
                   HoraInicio = new TimeSpan(13,0,0),
                   HoraFin = new TimeSpan(17,0,0)
               },
               new HorarioPrestador
               {
                   Id=5,
                   IdPrestadorEstablecimiento = 3,
                   HoraInicio = new TimeSpan(9,0,0),
                   HoraFin = new TimeSpan(13,0,0)
               },
               new HorarioPrestador
               {
                   Id=6,
                   IdPrestadorEstablecimiento = 4,
                   HoraInicio = new TimeSpan(10,0,0),
                   HoraFin = new TimeSpan(13,0,0)
               },
               new HorarioPrestador
               {
                   Id=7,
                   IdPrestadorEstablecimiento = 5,
                   HoraInicio = new TimeSpan(16,30,0),
                   HoraFin = new TimeSpan(20,0,0)
               },
               new HorarioPrestador
               {
                   Id=8,
                   IdPrestadorEstablecimiento = 6,
                   HoraInicio = new TimeSpan(18,0,0),
                   HoraFin = new TimeSpan(21,0,0)
               },
               new HorarioPrestador
               {
                   Id=9,
                   IdPrestadorEstablecimiento = 7,
                   HoraInicio = new TimeSpan(10,0,0),
                   HoraFin = new TimeSpan(14,0,0)
               },
               new HorarioPrestador
               {
                   Id=10,
                   IdPrestadorEstablecimiento = 8,
                   HoraInicio = new TimeSpan(19,0,0),
                   HoraFin = new TimeSpan(20,0,0)
               },
               new HorarioPrestador
               {
                   Id=11,
                   IdPrestadorEstablecimiento = 9,
                   HoraInicio = new TimeSpan(17,0,0),
                   HoraFin = new TimeSpan(20,0,0)
               },
               new HorarioPrestador
               {
                   Id=12,
                   IdPrestadorEstablecimiento = 10,
                   HoraInicio = new TimeSpan(11,0,0),
                   HoraFin = new TimeSpan(17,0,0)
               },
               new HorarioPrestador
               {
                   Id=13,
                   IdPrestadorEstablecimiento = 11,
                   HoraInicio = new TimeSpan(11,30,0),
                   HoraFin = new TimeSpan(15,0,0)
               },
               new HorarioPrestador
               {
                   Id=14,
                   IdPrestadorEstablecimiento = 12,
                   HoraInicio = new TimeSpan(17,0,0),
                   HoraFin = new TimeSpan(19,0,0)
               },
               new HorarioPrestador
               {
                   Id=15,
                   IdPrestadorEstablecimiento = 13,
                   HoraInicio = new TimeSpan(17,0,0),
                   HoraFin = new TimeSpan(18,0,0)
               },
               new HorarioPrestador
               {
                   Id=16,
                   IdPrestadorEstablecimiento = 14,
                   HoraInicio = new TimeSpan(17,0,0),
                   HoraFin = new TimeSpan(19,0,0)
               },
               new HorarioPrestador
               {
                   Id=17,
                   IdPrestadorEstablecimiento = 15,
                   HoraInicio = new TimeSpan(17,30,0),
                   HoraFin = new TimeSpan(20,0,0)
               },
               new HorarioPrestador
               {
                   Id=18,
                   IdPrestadorEstablecimiento = 16,
                   HoraInicio = new TimeSpan(16,0,0),
                   HoraFin = new TimeSpan(18,0,0)
               },
               new HorarioPrestador
               {
                   Id=19,
                   IdPrestadorEstablecimiento = 17,
                   HoraInicio = new TimeSpan(18,0,0),
                   HoraFin = new TimeSpan(19,0,0)
               },
               new HorarioPrestador
               {
                   Id=20,
                   IdPrestadorEstablecimiento = 18,
                   HoraInicio = new TimeSpan(16,0,0),
                   HoraFin = new TimeSpan(17,0,0)
               },
               new HorarioPrestador
               {
                   Id=21,
                   IdPrestadorEstablecimiento = 19,
                   HoraInicio = new TimeSpan(9,30,0),
                   HoraFin = new TimeSpan(12,30,0)
               },
               new HorarioPrestador
               {
                   Id=22,
                   IdPrestadorEstablecimiento = 20,
                   HoraInicio = new TimeSpan(16,0,0),
                   HoraFin = new TimeSpan(19,30,0)
               },
               new HorarioPrestador
               {
                   Id=23,
                   IdPrestadorEstablecimiento = 21,
                   HoraInicio = new TimeSpan(17,0,0),
                   HoraFin = new TimeSpan(21,0,0)
               },
               new HorarioPrestador
               {
                   Id=24,
                   IdPrestadorEstablecimiento = 22,
                   HoraInicio = new TimeSpan(14,30,0),
                   HoraFin = new TimeSpan(16,0,0)
               },
               new HorarioPrestador
               {   Id=25,
                   IdPrestadorEstablecimiento = 22,
                   HoraInicio = new TimeSpan(10,0,0),
                   HoraFin = new TimeSpan(11,0,0)
               },
               new HorarioPrestador
               {
                   Id=26,
                   IdPrestadorEstablecimiento = 22,
                   HoraInicio = new TimeSpan(17,30,0),
                   HoraFin = new TimeSpan(19,0,0)
               },
               new HorarioPrestador
               {
                   Id=27,
                   IdPrestadorEstablecimiento = 23,
                   HoraInicio = new TimeSpan(18,0,0),
                   HoraFin = new TimeSpan(20,0,0)
               },
               new HorarioPrestador
               {
                   Id=28,
                   IdPrestadorEstablecimiento = 24,
                   HoraInicio = new TimeSpan(18,0,0),
                   HoraFin = new TimeSpan(19,0,0)
               },
           };
        }
    }
}
