using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galenort.Dominio.Metadata
{
    public class EstablecimientoMetadata : IEntityTypeConfiguration<Establecimiento>
    {
        public void Configure(EntityTypeBuilder<Establecimiento> builder)
        {
            builder.Property(x => x.Direccion)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.IdLocalidad)
                .IsRequired();

            builder.Property(x => x.RazonSocial)
                .HasMaxLength(150)
                .IsRequired();

            builder.HasData(Seed());

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }

        public IEnumerable<Establecimiento> Seed()
        {
            return new List<Establecimiento>
            {
                new Establecimiento
                {
                    Id = 1,
                    IdLocalidad = 1,
                    Direccion = "Avenida Belgrano 2970",
                    RazonSocial = "Sanatorio Galeno S.C.E.I"
                },
                new Establecimiento
                {
                    Id = 2,
                    IdLocalidad = 1,
                    Direccion = "Jujuy 111",
                    RazonSocial = "Sanatorio C.I.M.S.A"
                },
                new Establecimiento
                {
                    Id = 3,
                    IdLocalidad = 1,
                    Direccion = "Avenida Mitre 268",
                    RazonSocial = "Sanatorio Central S.R.L"
                },
                new Establecimiento
                {
                    Id = 4,
                    IdLocalidad = 2,
                    Direccion = "Avenida Mitre 263",
                    RazonSocial = "Sanatorio Mitre S.R.L"
                },
            };
        }
    }
}
