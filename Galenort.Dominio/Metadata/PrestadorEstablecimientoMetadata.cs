using System;
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

            builder.Property(x => x.IdPrestador)
                .IsRequired();

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }
    }
}
