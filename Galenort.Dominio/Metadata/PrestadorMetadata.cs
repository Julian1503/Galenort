using System;
using System.Collections.Generic;
using System.Text;
using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.BouncyCastle.Crypto.Engines;

namespace Galenort.Dominio.Metadata
{
    public class PrestadorMetadata : IEntityTypeConfiguration<Prestador>
    {
        public void Configure(EntityTypeBuilder<Prestador> builder)
        {
            builder.Property(x => x.Apellido)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Nombre)
                .HasMaxLength(250)
                .IsRequired();

            builder.HasData(Seed());

            builder.HasQueryFilter(x => x.EstaEliminado == 0);
        }

        private IEnumerable<Prestador> Seed()
        {
            return new List<Prestador>
            {
                new Prestador
                {
                    Id = 1,
                    Apellido = "AGÜERO AVILA",
                    Nombre = "MARCELO"
                },
                new Prestador
                {
                    Id = 2,
                    Apellido = "ESCODAMAGLIA",
                    Nombre = "SERGIO"
                },
                new Prestador
                {
                    Id = 3,
                    Apellido = "CHAVEZ",
                    Nombre = "NILDA"
                },
                new Prestador
                {
                    Id = 4,
                    Apellido = "CABRAL",
                    Nombre = "CLELIA"
                },
                new Prestador
                {
                    Id = 5,
                    Apellido = "BENAGLIO",
                    Nombre = "HORACIO"
                },
                new Prestador
                {
                    Id = 6,
                    Apellido = "GIMENEZ",
                    Nombre = "NAZARENO"
                }, new Prestador
                {
                    Id = 7,
                    Apellido = "VENTURINI",
                    Nombre = "ARTURO"
                }, new Prestador
                {
                    Id = 8,
                    Apellido = "BAZA",
                    Nombre = "DAVID"
                }, new Prestador
                {
                    Id = 9,
                    Apellido = "FRAU",
                    Nombre = "DANIEL"
                },
                new Prestador
                {
                    Id = 10,
                    Apellido = "ARGAÑARAZ",
                    Nombre = "CARMEN"
                },

                new Prestador
                {
                    Id = 11,
                    Apellido = "VALDE LICO",
                    Nombre = "GUILLERMO"
                },

                new Prestador
                {
                    Id = 12,
                    Apellido = "FERNANDEZ",
                    Nombre = "SILVIO"
                },

                new Prestador
                {
                    Id = 13,
                    Apellido = "QUIROGA",
                    Nombre = "ADRIAN"
                },

                new Prestador
                {
                    Id = 14,
                    Apellido = "JUAREZ",
                    Nombre = "PABLO"
                },

                new Prestador
                {
                    Id = 15,
                    Apellido = "FIGUEROA",
                    Nombre = "RICARDO"
                },

                new Prestador
                {
                    Id = 16,
                    Apellido = "LAZARTE",
                    Nombre = "JORGE"
                },

                new Prestador
                {
                    Id = 17,
                    Apellido = "GEREZ",
                    Nombre = "LILIANA"
                },

                new Prestador
                {
                    Id = 18,
                    Apellido = "NEME",
                    Nombre = "GRACIELA"
                },

                new Prestador
                {
                    Id = 19,
                    Apellido = "TOBIAS TERUEL",
                    Nombre = "OSCAR"
                },

                new Prestador
                {
                    Id = 20,
                    Apellido = "LOPEZ",
                    Nombre = "LORENA"
                },

                new Prestador
                {
                    Id = 21,
                    Apellido = "PERPIGNAL",
                    Nombre = "LUISA"
                },

                new Prestador
                {
                    Id = 22,
                    Apellido = "SILVA",
                    Nombre = "ENZO"
                },

                new Prestador
                {
                    Id = 23,
                    Apellido = "MENA",
                    Nombre = "VICENTE"
                },
                new Prestador
                {
                    Id = 24,
                    Apellido = "CANSECO",
                    Nombre = "RICARDO"
                },
            };
        }
    }
}
