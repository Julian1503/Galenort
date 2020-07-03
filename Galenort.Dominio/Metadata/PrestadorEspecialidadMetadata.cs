using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            builder.HasQueryFilter(x => x.EstaEliminado == false);
        }
    }
}
