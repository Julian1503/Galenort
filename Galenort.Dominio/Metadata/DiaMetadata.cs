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
                   Descripcion = "Lunes"
               },
               new Dia
               {
                   Id=2,
                   Descripcion = "Martes"
               },
               new Dia
               {
                   Id=3,
                   Descripcion = "Miercoles"
               },
               new Dia
               {
                   Id=4,
                   Descripcion = "Jueves"
               },
               new Dia
               {
                   Id=5,
                   Descripcion = "Viernes"
               },
               new Dia
               {
                   Id=6,
                   Descripcion = "Sabado"
               },
               new Dia
               {
                   Id=7,
                   Descripcion = "Domingo"
               },
           };
        }
    }
}
