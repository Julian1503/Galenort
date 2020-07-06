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
            builder.Property(x => x.Calle)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Localidad)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.RazonSocial)
                .HasMaxLength(150)
                .IsRequired();

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }
    }
}
