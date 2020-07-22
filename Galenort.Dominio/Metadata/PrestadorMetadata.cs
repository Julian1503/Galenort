using Galenort.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

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
                    Apellido = "Agüero Avila",
                    Nombre = "Marcelo"
                },
                new Prestador
                {
                    Id = 2,
                    Apellido = "Escodamaglia",
                    Nombre = "Sergio"
                },
                new Prestador
                {
                    Id = 3,
                    Apellido = "Chavez",
                    Nombre = "Nilda"
                },
                new Prestador
                {
                    Id = 4,
                    Apellido = "Cabral",
                    Nombre = "Clelia"
                },
                new Prestador
                {
                    Id = 5,
                    Apellido = "Benaglio",
                    Nombre = "Horacio"
                },
                new Prestador
                {
                    Id = 6,
                    Apellido = "Gimenez",
                    Nombre = "Nazareno"
                }, new Prestador
                {
                    Id = 7,
                    Apellido = "Venturini",
                    Nombre = "Arturo"
                }, new Prestador
                {
                    Id = 8,
                    Apellido = "Baza",
                    Nombre = "David"
                }, new Prestador
                {
                    Id = 9,
                    Apellido = "Frau",
                    Nombre = "Daniel"
                },
                new Prestador
                {
                    Id = 10,
                    Apellido = "Argañaraz",
                    Nombre = "Carmen"
                },

                new Prestador
                {
                    Id = 11,
                    Apellido = "Valde lico",
                    Nombre = "Guillermo"
                },

                new Prestador
                {
                    Id = 12,
                    Apellido = "Fernandez",
                    Nombre = "Silvio"
                },

                new Prestador
                {
                    Id = 13,
                    Apellido = "Quiroga",
                    Nombre = "Adrian"
                },

                new Prestador
                {
                    Id = 14,
                    Apellido = "Juarez",
                    Nombre = "Pablo"
                },

                new Prestador
                {
                    Id = 15,
                    Apellido = "Figueroa",
                    Nombre = "Ricardo"
                },

                new Prestador
                {
                    Id = 16,
                    Apellido = "Lazarte",
                    Nombre = "Jorge"
                },

                new Prestador
                {
                    Id = 17,
                    Apellido = "Gerez",
                    Nombre = "Liliana"
                },

                new Prestador
                {
                    Id = 18,
                    Apellido = "Neme",
                    Nombre = "Graciela"
                },

                new Prestador
                {
                    Id = 19,
                    Apellido = "Tobias Teruel",
                    Nombre = "Oscar"
                },

                new Prestador
                {
                    Id = 20,
                    Apellido = "Lopez",
                    Nombre = "Lorena"
                },

                new Prestador
                {
                    Id = 21,
                    Apellido = "Perpignal",
                    Nombre = "Luisa"
                },

                new Prestador
                {
                    Id = 22,
                    Apellido = "Silva",
                    Nombre = "Enzo"
                },

                new Prestador
                {
                    Id = 23,
                    Apellido = "Mena",
                    Nombre = "Vicente"
                },
                new Prestador
                {
                    Id = 24,
                    Apellido = "Canseco",
                    Nombre = "Ricardo"
                }
                ,
                new Prestador
                {
                    Id = 25,
                    Apellido = "Gómez",
                    Nombre = "Sergio"
                },
                new Prestador
                {
                    Id = 26,
                    Apellido = "Mena",
                    Nombre = "Hernán"
                },
                new Prestador
                {
                    Id = 27,
                    Apellido = "Ramos",
                    Nombre = "Hernández"
                },
                new Prestador
                {
                    Id = 28,
                    Apellido = "Robles",
                    Nombre = "Chavez"
                },
                new Prestador
                {
                    Id = 29,
                    Apellido = "Nieto",
                    Nombre = "Silva"
                },
                new Prestador
                {
                    Id = 30,
                    Apellido = "Brodesen",
                    Nombre = "Liliana"
                },
                new Prestador
                {
                    Id = 31,
                    Apellido = "Jaime",
                    Nombre = "Sebastian"
                },
                new Prestador
                {
                    Id = 32,
                    Apellido = "Fernandez",
                    Nombre = "Gómez"
                },
                new Prestador
                {
                    Id = 33,
                    Apellido = "Erbetta",
                    Nombre = "Ruben Julio"
                },
                new Prestador
                {
                    Id = 34,
                    Apellido = "Andjel",
                    Nombre = "Germán Alejandro"
                },
                new Prestador
                {
                    Id = 35,
                    Apellido = "Saracho",
                    Nombre = "Victor Manuel"
                }, new Prestador
                {
                    Id = 36,
                    Apellido = "Raskosky",
                    Nombre = "Luis Raul"
                },
                new Prestador
                {
                    Id = 37,
                    Apellido = "Azcárate Pacheres",
                    Nombre = "Aníbal"
                },
                new Prestador
                {
                    Id = 38,
                    Apellido = "Zelada",
                    Nombre = "Fernando"
                },
                new Prestador
                {
                    Id = 39,
                    Apellido = "Michel",
                    Nombre = "  Jhony"
                },
                new Prestador
                {
                    Id = 40,
                    Apellido = "Rojas",
                    Nombre = "Adrian"
                },
                new Prestador
                {
                    Id = 41,
                    Apellido = "Ruiz Diaz",
                    Nombre = "Hector"
                },
                new Prestador
                {
                    Id = 42,
                    Apellido = "Ale",
                    Nombre = "Pablo"
                },
                new Prestador
                {
                    Id = 43,
                    Apellido = "Ale Levin",
                    Nombre = "Walter"
                },
                new Prestador
                {
                    Id = 44,
                    Apellido = "Paz",
                    Nombre = "Claudio"
                },
                new Prestador
                {
                    Id = 45,
                    Apellido = "Brito",
                    Nombre = "Guillermo"
                },
                new Prestador
                {
                    Id = 46,
                    Apellido = "Martinez",
                    Nombre = "Fabian"
                },
                new Prestador
                {
                    Id = 47,
                    Apellido = "Triguero",
                    Nombre = "Felix"
                },
                new Prestador
                {
                    Id = 48,
                    Apellido = "Raya",
                    Nombre = "Jose"
                },
                new Prestador
                {
                    Id = 49,
                    Apellido = "Suarez",
                    Nombre = "Jorge"
                },
                new Prestador
                {
                    Id = 50,
                    Apellido = "Alonso",
                    Nombre = "Gustavo"
                },
                new Prestador
                {
                    Id = 51,
                    Apellido = "Campero",
                    Nombre = "Silvia Graciela"
                },
                new Prestador
                {
                    Id = 52,
                    Apellido = "Romaño",
                    Nombre = "Murga"
                },
                new Prestador
                {
                    Id = 53,
                    Apellido = "Juan Ramon",
                    Nombre = "Cecilia"
                },
                new Prestador
                {
                    Id = 54,
                    Apellido = "Rovarini",
                    Nombre = "Ana"
                },
                new Prestador
                {
                    Id = 55,
                    Apellido = "Chehade",
                    Nombre = "Wadi"
                },
                new Prestador
                {
                    Id = 56,
                    Apellido = "Almeida",
                    Nombre = "Maria"
                },
                new Prestador
                {
                    Id = 57,
                    Apellido = "Perez Ordoñes",
                    Nombre = "Veronica"
                },
                new Prestador
                {
                    Id = 58,
                    Apellido = "Alvarez",
                    Nombre = "Carlos"
                },
                new Prestador
                {
                    Id = 59,
                    Apellido = "Fernandez",
                    Nombre = "Alvaro"
                },
                new Prestador
                {
                    Id = 60,
                    Apellido = "Perez",
                    Nombre = "Mulki"
                },
                new Prestador
                {
                    Id = 61,
                    Apellido = "Martinez",
                    Nombre = "Javier"
                },
                new Prestador
                {
                    Id = 62,
                    Apellido = "Avellaneda",
                    Nombre = "Maria"
                },
                new Prestador
                {
                    Id = 63,
                    Apellido = "Fierro",
                    Nombre = "Jorge"
                },
                new Prestador
                {
                    Id = 64,
                    Apellido = "Ledesma",
                    Nombre = "Jesus Emiliano"
                },
                new Prestador
                {
                    Id = 65,
                    Apellido = "Fadel",
                    Nombre = "Julio"
                }
            };
        }
    }
}
