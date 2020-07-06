using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galenort.Dominio.Metadata
{
    public class DiaHorarioMetadata : IEntityTypeConfiguration<DiaHorario>
    {
        public void Configure(EntityTypeBuilder<DiaHorario> builder)
        {
            builder.Property(x => x.IdDia)
                .IsRequired();

            builder.Property(x => x.IdDia)
                .IsRequired();

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }
    }
}
