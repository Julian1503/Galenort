using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.BouncyCastle.Crypto.Engines;

namespace Galenort.Dominio.Metadata
{
    public class EspecialidadMetadata : IEntityTypeConfiguration<Especialidad>
    {
        public void Configure(EntityTypeBuilder<Especialidad> builder)
        {
            builder.Property(x => x.Descripcion)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasData(Seed());

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }

        private IEnumerable<Especialidad> Seed()
        {
            return new List<Especialidad>
            {
                new Especialidad
                {
                    Id=1,
                    Descripcion = "FLEBOLOGIA"
                },
                new Especialidad
                {
                    Id=2,
                    Descripcion = "ENDOCRINOLOGIA"
                },
                new Especialidad
                {
                    Id=3,
                    Descripcion = "ECOGRAFIA"
                },
                new Especialidad
                {
                    Id=4,
                    Descripcion = "NEUROLOGIA"
                },
                new Especialidad
                {
                    Id=5,
                    Descripcion = "CLINICO"
                },
                new Especialidad
                {
                    Id=6,
                    Descripcion = "DERMATOLOGIA"
                },
                new Especialidad
                {
                    Id=7,
                    Descripcion = "GINECOLOGIA"
                },
                new Especialidad
                {
                    Id=8,
                    Descripcion = "TRAUMATOLOGIA"
                },
                new Especialidad
                {
                    Id=9,
                    Descripcion = "CIRUGIA GRAL"
                },
                new Especialidad
                {
                    Id=10,
                    Descripcion = "PROCTOLOGIA"
                },
                new Especialidad
                {
                    Id=11,
                    Descripcion = "CARDIOLOGIA"
                }
                ,
                new Especialidad
                {
                    Id=12,
                    Descripcion = "NEUMONOLOGIA"
                },
                new Especialidad
                {
                    Id=13,
                    Descripcion = "UROLOGIA"
                },
                new Especialidad
                {
                    Id=14,
                    Descripcion = "PSICOLOGIA"
                }
            };
        }
    }
}
