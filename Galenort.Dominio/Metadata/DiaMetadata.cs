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

            builder.HasQueryFilter(x => x.EstaEliminado == false);

            builder.HasData(Seed());
        }

        private List<Dia> Seed()
        {
           return new List<Dia>
           {
               new Dia
               {
                   Id=1,
                   Descripcion = "Lunes",
                   EstaEliminado = false
               },
               new Dia
               {
                   Id=1,
                   Descripcion = "Martes",
                   EstaEliminado = false
               },
               new Dia
               {
                   Id=1,
                   Descripcion = "Miercoles",
                   EstaEliminado = false
               },
               new Dia
               {
                   Id=1,
                   Descripcion = "Jueves",
                   EstaEliminado = false
               },
               new Dia
               {
                   Id=1,
                   Descripcion = "Viernes",
                   EstaEliminado = false
               },
               new Dia
               {
                   Id=1,
                   Descripcion = "Sabado",
                   EstaEliminado = false
               },
               new Dia
               {
                   Id=1,
                   Descripcion = "Domingo",
                   EstaEliminado = false
               },
           };
        }
    }
}
