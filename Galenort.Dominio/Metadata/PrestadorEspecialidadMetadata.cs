using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.BouncyCastle.Crypto.Engines;

namespace Galenort.Dominio.Metadata
{
    public class PrestadorEspecialidadMetadata : IEntityTypeConfiguration<PrestadorEspecialidad>
    {
        public void Configure(EntityTypeBuilder<PrestadorEspecialidad> builder)
        {
            builder.Property(x => x.IdEspecialidad)
                .IsRequired();

            builder.Property(x => x.IdPrestador)
                .IsRequired();

            builder.HasData(Seed());

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }

        private IEnumerable<PrestadorEspecialidad> Seed()
        {
            return new List<PrestadorEspecialidad>
            {
                new PrestadorEspecialidad
                {
                    Id = 1,
                    IdEspecialidad = 1,
                    IdPrestador = 1
                },
                new PrestadorEspecialidad
                {
                    Id = 2,
                    IdEspecialidad = 1,
                    IdPrestador = 2
                },
                new PrestadorEspecialidad
                {
                    Id = 3,
                    IdEspecialidad = 2,
                    IdPrestador =3
                },
                new PrestadorEspecialidad
                {
                    Id = 4,
                    IdEspecialidad =2,
                    IdPrestador = 4
                },
                new PrestadorEspecialidad
                {
                    Id = 5,
                    IdEspecialidad = 3,
                    IdPrestador =5
                },
                new PrestadorEspecialidad
                {
                    Id = 6,
                    IdEspecialidad = 4,
                    IdPrestador = 6
                },
                new PrestadorEspecialidad
                {
                    Id = 7,
                    IdEspecialidad = 5,
                    IdPrestador = 7
                },
                new PrestadorEspecialidad
                {
                    Id = 8,
                    IdEspecialidad = 6,
                    IdPrestador =8
                },
                new PrestadorEspecialidad
                {
                    Id = 9,
                    IdEspecialidad = 7,
                    IdPrestador = 9
                },
                new PrestadorEspecialidad
                {
                    Id = 10,
                    IdEspecialidad = 7,
                    IdPrestador = 10
                },
                new PrestadorEspecialidad
                {
                    Id = 11,
                    IdEspecialidad = 8,
                    IdPrestador =11
                },
                new PrestadorEspecialidad
                {
                    Id = 12,
                    IdEspecialidad =8 ,
                    IdPrestador =12
                },
                new PrestadorEspecialidad
                {
                    Id = 13,
                    IdEspecialidad = 8,
                    IdPrestador =13
                },
                new PrestadorEspecialidad
                {
                    Id = 14,
                    IdEspecialidad =8 ,
                    IdPrestador =14
                },
                new PrestadorEspecialidad
                {
                    Id = 15,
                    IdEspecialidad = 9,
                    IdPrestador =15
                },
                new PrestadorEspecialidad
                {
                    Id = 16,
                    IdEspecialidad = 9,
                    IdPrestador = 16
                },
                new PrestadorEspecialidad
                {
                    Id = 17,
                    IdEspecialidad = 10,
                    IdPrestador = 17
                },
                new PrestadorEspecialidad
                {
                    Id = 18,
                    IdEspecialidad = 11,
                    IdPrestador = 18
                },
                new PrestadorEspecialidad
                {
                    Id = 19,
                    IdEspecialidad = 11,
                    IdPrestador = 19
                },
                new PrestadorEspecialidad
                {
                    Id = 20,
                    IdEspecialidad = 11,
                    IdPrestador = 20
                },
                new PrestadorEspecialidad
                {
                    Id = 21,
                    IdEspecialidad = 12,
                    IdPrestador = 21
                },
                new PrestadorEspecialidad
                {
                    Id = 22,
                    IdEspecialidad = 13,
                    IdPrestador = 22
                },
                new PrestadorEspecialidad
                {
                    Id = 23,
                    IdEspecialidad = 5,
                    IdPrestador = 23
                },
                new PrestadorEspecialidad
                {
                    Id = 24,
                    IdEspecialidad = 14,
                    IdPrestador = 24
                },
                new PrestadorEspecialidad
                {
                    Id = 25,
                    IdEspecialidad = 9,
                    IdPrestador = 25
                },
                new PrestadorEspecialidad
                {
                    Id = 26,
                    IdEspecialidad = 9,
                    IdPrestador = 26
                },
                new PrestadorEspecialidad
                {
                    Id = 27,
                    IdEspecialidad = 7,
                    IdPrestador = 27
                },
                new PrestadorEspecialidad
                {
                    Id = 28,
                    IdEspecialidad = 7,
                    IdPrestador = 28
                },
                new PrestadorEspecialidad
                {
                    Id = 29,
                    IdEspecialidad = 7,
                    IdPrestador = 29
                },
                new PrestadorEspecialidad
                {
                    Id = 30,
                    IdEspecialidad = 15,
                    IdPrestador = 30
                },
                new PrestadorEspecialidad
                {
                    Id = 31,
                    IdEspecialidad = 13,
                    IdPrestador = 31
                },
                new PrestadorEspecialidad
                {
                    Id = 32,
                    IdEspecialidad = 13,
                    IdPrestador = 32
                },
                new PrestadorEspecialidad
                {
                    Id = 33,
                    IdEspecialidad = 16,
                    IdPrestador = 33
                },
                new PrestadorEspecialidad
                {
                    Id = 34,
                    IdEspecialidad = 4,
                    IdPrestador = 34
                },
                new PrestadorEspecialidad
                {
                    Id = 35,
                    IdEspecialidad = 11,
                    IdPrestador = 35
                },
                new PrestadorEspecialidad
                {
                    Id = 36,
                    IdEspecialidad = 9,
                    IdPrestador = 36
                },
                new PrestadorEspecialidad
                {
                    Id = 37,
                    IdEspecialidad = 5,
                    IdPrestador = 37
                },
            };
        }
    }
}
