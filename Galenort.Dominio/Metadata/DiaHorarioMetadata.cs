using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.BouncyCastle.Crypto.Engines;

namespace Galenort.Dominio.Metadata
{
    public class DiaHorarioMetadata : IEntityTypeConfiguration<DiaHorario>
    {
        public void Configure(EntityTypeBuilder<DiaHorario> builder)
        {
            builder.Property(x => x.IdDia)
                .IsRequired();

            builder.Property(x => x.IdHorarioPrestador)
                .IsRequired();

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }

        private IEnumerable<DiaHorario> Seed()
        {
            return new List<DiaHorario>
            {
                new DiaHorario
                {
                    Id = 1,
                    IdHorarioPrestador = 1,
                    IdDia= 2,
                },
                new DiaHorario
                {
                    Id = 2,
                    IdHorarioPrestador = 1,
                    IdDia= 4,
                },
                new DiaHorario
                {
                    Id = 3,
                    IdHorarioPrestador = 1,
                    IdDia= 5,
                },
                new DiaHorario
                {
                    Id = 4,
                    IdHorarioPrestador = 2,
                    IdDia= 1,
                },
                new DiaHorario
                {
                    Id = 5,
                    IdHorarioPrestador = 3,
                    IdDia= 1,
                },
                new DiaHorario
                {
                    Id = 6,
                    IdHorarioPrestador = 3,
                    IdDia= 3,
                },
                new DiaHorario
                {
                    Id = 7,
                    IdHorarioPrestador = 4,
                    IdDia= 2,
                },
                new DiaHorario
                {
                    Id = 8,
                    IdHorarioPrestador = 4,
                    IdDia= 4,
                },
                new DiaHorario
                {
                    Id = 9,
                    IdHorarioPrestador = 5,
                    IdDia= 5,
                },
                new DiaHorario
                {
                    Id = 10,
                    IdHorarioPrestador = 6,
                    IdDia= 1,
                },
                new DiaHorario
                {
                    Id = 11,
                    IdHorarioPrestador = 6,
                    IdDia= 2,
                },
                new DiaHorario
                {
                    Id = 12,
                    IdHorarioPrestador = 6,
                    IdDia= 3,
                },
                new DiaHorario
                {
                    Id = 13,
                    IdHorarioPrestador = 7,
                    IdDia= 6,
                },
                new DiaHorario
                {
                    Id = 14,
                    IdHorarioPrestador = 8,
                    IdDia= 4,
                },
                new DiaHorario
                {
                    Id = 15,
                    IdHorarioPrestador =9,
                    IdDia=6,
                },
                new DiaHorario
                {
                    Id = 16,
                    IdHorarioPrestador =10,
                    IdDia=6,
                },
                new DiaHorario
                {
                    Id = 17,
                    IdHorarioPrestador =11,
                    IdDia=6,
                },
                new DiaHorario
                {
                    Id = 18,
                    IdHorarioPrestador =12,
                    IdDia=5,
                },
                new DiaHorario
                {
                    Id = 19,
                    IdHorarioPrestador =13,
                    IdDia=1,
                },
                new DiaHorario
                {
                    Id = 20,
                    IdHorarioPrestador =13,
                    IdDia=3,
                },
                new DiaHorario
                {
                    Id = 21,
                    IdHorarioPrestador =13,
                    IdDia=5,
                },
                new DiaHorario
                {
                    Id = 22,
                    IdHorarioPrestador =14,
                    IdDia=1,
                },
                new DiaHorario
                {
                    Id = 23,
                    IdHorarioPrestador =15,
                    IdDia=3,
                },
                new DiaHorario
                {
                    Id = 24,
                    IdHorarioPrestador =16,
                    IdDia=4,
                },
                new DiaHorario
                {
                    Id = 25,
                    IdHorarioPrestador =17,
                    IdDia=1,
                },
                new DiaHorario
                {
                    Id = 26,
                    IdHorarioPrestador =17,
                    IdDia=3,
                },
                new DiaHorario
                {
                    Id = 27,
                    IdHorarioPrestador =17,
                    IdDia=5,
                },
                new DiaHorario
                {
                    Id = 28,
                    IdHorarioPrestador =18,
                    IdDia=1,
                },
                new DiaHorario
                {
                    Id = 29,
                    IdHorarioPrestador =18,
                    IdDia=3,
                },
                new DiaHorario
                {
                    Id = 30,
                    IdHorarioPrestador =18,
                    IdDia=5,
                },
                new DiaHorario
                {
                    Id = 31,
                    IdHorarioPrestador =19,
                    IdDia=3,
                },
                new DiaHorario
                {
                    Id = 32,
                    IdHorarioPrestador =20,
                    IdDia=1,
                },
                new DiaHorario
                {
                    Id = 33,
                    IdHorarioPrestador =20,
                    IdDia=3,
                },
                new DiaHorario
                {
                    Id = 34,
                    IdHorarioPrestador =21,
                    IdDia=3,
                },
                new DiaHorario
                {
                    Id = 35,
                    IdHorarioPrestador =21,
                    IdDia=5,
                },
                new DiaHorario
                {
                    Id = 36,
                    IdHorarioPrestador =22,
                    IdDia=4,
                },
                new DiaHorario
                {
                    Id = 37,
                    IdHorarioPrestador =23,
                    IdDia=1,
                },
                new DiaHorario
                {
                    Id = 38,
                    IdHorarioPrestador =23,
                    IdDia=2,
                },
                new DiaHorario
                {
                    Id = 39,
                    IdHorarioPrestador =23,
                    IdDia=4,
                },
                new DiaHorario
                {
                    Id = 40,
                    IdHorarioPrestador =24,
                    IdDia=1,
                },

                new DiaHorario
                {
                    Id = 41,
                    IdHorarioPrestador =25,
                    IdDia=3,
                },
                new DiaHorario
                {
                    Id = 42,
                    IdHorarioPrestador =26,
                    IdDia=5,
                },
                new DiaHorario
                {
                    Id = 43,
                    IdHorarioPrestador =27,
                    IdDia=2,
                },

                new DiaHorario
                {
                    Id = 44,
                    IdHorarioPrestador =27,
                    IdDia=4,
                },
                new DiaHorario
                {
                    Id = 45,
                    IdHorarioPrestador =28,
                    IdDia=1,
                },
                new DiaHorario
                {
                    Id = 46,
                    IdHorarioPrestador =28,
                    IdDia=2,
                },
                new DiaHorario
                {
                    Id = 47,
                    IdHorarioPrestador =28,
                    IdDia=4,
                },
            };
        }
    }
}
