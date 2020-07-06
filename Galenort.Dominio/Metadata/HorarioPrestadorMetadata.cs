using System;
using System.Collections.Generic;
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
            builder.Property(x => x.IdPrestador)
                .IsRequired();

            builder.Property(x => x.IdHorario)
                .IsRequired();

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }
    }
}
