using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galenort.Dominio.Metadata
{
    public class PrestadorMetadata : IEntityTypeConfiguration<Prestador>
    {
        public void Configure(EntityTypeBuilder<Prestador> builder)
        {
            builder.Property(x => x.Apellido)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Nombre)
                .HasMaxLength(250)
                .IsRequired();
        
            builder.HasQueryFilter(x => x.EstaEliminado == false);
        }
    }
}
