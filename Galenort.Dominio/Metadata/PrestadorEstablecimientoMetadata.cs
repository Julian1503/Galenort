﻿using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galenort.Dominio.Metadata
{
    public class PrestadorEstablecimientoMetadata : IEntityTypeConfiguration<PrestadorEstablecimiento>
    {
        public void Configure(EntityTypeBuilder<PrestadorEstablecimiento> builder)
        {
            builder.Property(x => x.IdEstablecimiento)
                .IsRequired();

            builder.Property(x => x.IdPrestadorEspecialidad)
                .IsRequired();

            builder.HasData(Seed());

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }

        private IEnumerable<PrestadorEstablecimiento> Seed()
        {
            return new List<PrestadorEstablecimiento>
            {
                new PrestadorEstablecimiento
                {
                    Id = 1,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 1
                },
                new PrestadorEstablecimiento
                {
                    Id = 2,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 2
                },
                new PrestadorEstablecimiento
                {
                    Id = 3,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 3
                },
                new PrestadorEstablecimiento
                {
                    Id = 4,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 4
                },
                new PrestadorEstablecimiento
                {
                    Id = 5,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 5
                },
                new PrestadorEstablecimiento
                {
                    Id = 6,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 6
                },
                new PrestadorEstablecimiento
                {
                    Id = 7,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 7
                },
                new PrestadorEstablecimiento
                {
                    Id = 8,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 8
                },
                new PrestadorEstablecimiento
                {
                    Id = 9,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 9
                },
                new PrestadorEstablecimiento
                {
                    Id = 10,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 10
                },
                new PrestadorEstablecimiento
                {
                    Id = 11,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 11
                },
                new PrestadorEstablecimiento
                {
                    Id = 12,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 12
                },
                new PrestadorEstablecimiento
                {
                    Id = 13,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 13
                },
                new PrestadorEstablecimiento
                {
                    Id = 14,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 14
                },
                new PrestadorEstablecimiento
                {
                    Id = 15,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 15
                },
                new PrestadorEstablecimiento
                {
                    Id = 16,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 16
                },
                new PrestadorEstablecimiento
                {
                    Id = 17,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 17
                },
                new PrestadorEstablecimiento
                {
                    Id = 18,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 18
                },
                new PrestadorEstablecimiento
                {
                    Id = 19,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 19
                },
                new PrestadorEstablecimiento
                {
                    Id = 20,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 20
                },
                new PrestadorEstablecimiento
                {
                    Id = 21,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 21
                },
                new PrestadorEstablecimiento
                {
                    Id = 22,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 22
                },
                new PrestadorEstablecimiento
                {
                    Id = 23,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 23
                },
                new PrestadorEstablecimiento
                {
                    Id = 24,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 24
                },
                new PrestadorEstablecimiento
                {
                    Id = 25,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 25
                },
                new PrestadorEstablecimiento
                {
                    Id = 26,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 26
                },
                new PrestadorEstablecimiento
                {
                    Id = 27,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 27
                },
                new PrestadorEstablecimiento
                {
                    Id = 28,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 28
                },
                new PrestadorEstablecimiento
                {
                    Id = 29,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 29
                },
                new PrestadorEstablecimiento
                {
                    Id = 30,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 30
                },
                new PrestadorEstablecimiento
                {
                    Id = 31,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 31
                },
                new PrestadorEstablecimiento
                {
                    Id = 32,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 32
                },
                new PrestadorEstablecimiento
                {
                    Id = 33,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 33
                },
                new PrestadorEstablecimiento
                {
                    Id = 34,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 34
                },
                new PrestadorEstablecimiento
                {
                    Id = 35,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 35
                },
                new PrestadorEstablecimiento
                {
                    Id = 36,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 36
                },
                new PrestadorEstablecimiento
                {
                    Id = 37,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 37
                },

            };
        }
    }
}
