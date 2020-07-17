using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galenort.Dominio.Metadata
{
    public class DiaMetadata : IEntityTypeConfiguration<Dia>
    {
        public void Configure(EntityTypeBuilder<Dia> builder)
        {
            builder.Property(x => x.Descripcion)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasQueryFilter(x => x.EstaEliminado == 0);

            builder.HasData(Seed());
        }

        private List<Dia> Seed()
        {
           return new List<Dia>
           {
               new Dia
               {
                   Id=1,
                   Descripcion = "LUNES"
               },
               new Dia
               {
                   Id=2,
                   Descripcion = "MARTES"
               },
               new Dia
               {
                   Id=3,
                   Descripcion = "MIERCOLES"
               },
               new Dia
               {
                   Id=4,
                   Descripcion = "JUEVES"
               },
               new Dia
               {
                   Id=5,
                   Descripcion = "VIERNES"
               },
               new Dia
               {
                   Id=6,
                   Descripcion = "LUNES A VIERNES"
               }
           };
        }
    }
}
