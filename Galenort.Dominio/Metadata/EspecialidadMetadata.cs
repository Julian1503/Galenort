using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galenort.Dominio.Metadata
{
    public class EspecialidadMetadata : IEntityTypeConfiguration<Especialidad>
    {
        public void Configure(EntityTypeBuilder<Especialidad> builder)
        {
            builder.Property(x => x.Descripcion)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasQueryFilter(x => x.EstaEliminado);
        }
    }
}
