using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.BouncyCastle.Crypto.Engines;

namespace Galenort.Dominio.Metadata
{
    public class LocalidadMetadata : IEntityTypeConfiguration<Localidad>
    {
        public void Configure(EntityTypeBuilder<Localidad> builder)
        {
            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();
            builder.HasData(Seed());
            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }

        private IEnumerable<Localidad> Seed()
        {
            return new List<Localidad>
            {
                new Localidad
                {
                    Id=1,
                    Descripcion = "San Miguel de Tucumán"
                },
                new Localidad
                {
                    Id=2,
                    Descripcion = "Aguilares"
                },
            };
        }
    }
}
