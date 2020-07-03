using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galenort.Dominio.Metadata
{
    public class HorarioMetadata : IEntityTypeConfiguration<Horario>
    {
        public void Configure(EntityTypeBuilder<Horario> builder)
        {
            builder.Property(x => x.HoraFin)
                .HasColumnType("Time")
                .IsRequired();

            builder.Property(x => x.HoraIncio)
                .HasColumnType("Time")
                .IsRequired();

            builder.HasQueryFilter(x => x.EstaEliminado == false);
        }
    }
}
