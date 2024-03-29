﻿// <auto-generated />
using System;
using Galenort.Infraestructura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Galenort.Infraestructura.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200714052646_migration1307")]
    partial class migration1307
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Galenort.Dominio.Entidades.Dia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<short>("EstaEliminado");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Dias");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Descripcion = "LUNES",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 2L,
                            Descripcion = "MARTES",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 3L,
                            Descripcion = "MIERCOLES",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 4L,
                            Descripcion = "JUEVES",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 5L,
                            Descripcion = "VIERNES",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 6L,
                            Descripcion = "LUNES A VIERNES",
                            EstaEliminado = (short)0
                        });
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.DiaHorario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("EstaEliminado");

                    b.Property<long>("IdDia");

                    b.Property<long>("IdHorarioPrestador");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IdDia");

                    b.HasIndex("IdHorarioPrestador");

                    b.ToTable("DiaHorarios");
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.Especialidad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<short>("EstaEliminado");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Especialidades");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Descripcion = "FLEBOLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 2L,
                            Descripcion = "ENDOCRINOLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 3L,
                            Descripcion = "ECOGRAFIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 4L,
                            Descripcion = "NEUROLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 5L,
                            Descripcion = "CLINICO",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 6L,
                            Descripcion = "DERMATOLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 7L,
                            Descripcion = "GINECOLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 8L,
                            Descripcion = "TRAUMATOLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 9L,
                            Descripcion = "CIRUGIA GRAL",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 10L,
                            Descripcion = "PROCTOLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 11L,
                            Descripcion = "CARDIOLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 12L,
                            Descripcion = "NEUMONOLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 13L,
                            Descripcion = "UROLOGIA",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 14L,
                            Descripcion = "PSICOLOGIA",
                            EstaEliminado = (short)0
                        });
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.Establecimiento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<short>("EstaEliminado");

                    b.Property<long>("IdLocalidad");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IdLocalidad");

                    b.ToTable("Establecimientos");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Direccion = "Avenida Belgrano 2970",
                            EstaEliminado = (short)0,
                            IdLocalidad = 1L,
                            RazonSocial = "Sanatorio Galeno S.C.E.I"
                        },
                        new
                        {
                            Id = 2L,
                            Direccion = "Jujuy 111",
                            EstaEliminado = (short)0,
                            IdLocalidad = 1L,
                            RazonSocial = "Sanatorio C.I.M.S.A"
                        },
                        new
                        {
                            Id = 3L,
                            Direccion = "Avenida Mitre 268",
                            EstaEliminado = (short)0,
                            IdLocalidad = 1L,
                            RazonSocial = "Sanatorio Central S.R.L"
                        },
                        new
                        {
                            Id = 4L,
                            Direccion = "Avenida Mitre 263",
                            EstaEliminado = (short)0,
                            IdLocalidad = 2L,
                            RazonSocial = "Sanatorio Mitre S.R.L"
                        });
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.HorarioPrestador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("EstaEliminado");

                    b.Property<TimeSpan>("HoraFin")
                        .HasColumnType("Time");

                    b.Property<TimeSpan>("HoraInicio")
                        .HasColumnType("Time");

                    b.Property<long>("IdPrestadorEstablecimiento");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IdPrestadorEstablecimiento");

                    b.ToTable("HorarioPrestadores");
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.Localidad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<short>("EstaEliminado");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Localidades");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Descripcion = "San Miguel de Tucumán",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 2L,
                            Descripcion = "Aguilares",
                            EstaEliminado = (short)0
                        });
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.Prestador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<short>("EstaEliminado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Prestadores");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Apellido = "AGÜERO AVILA",
                            EstaEliminado = (short)0,
                            Nombre = "MARCELO"
                        },
                        new
                        {
                            Id = 2L,
                            Apellido = "ESCODAMAGLIA",
                            EstaEliminado = (short)0,
                            Nombre = "SERGIO"
                        },
                        new
                        {
                            Id = 3L,
                            Apellido = "CHAVEZ",
                            EstaEliminado = (short)0,
                            Nombre = "NILDA"
                        },
                        new
                        {
                            Id = 4L,
                            Apellido = "CABRAL",
                            EstaEliminado = (short)0,
                            Nombre = "CLELIA"
                        },
                        new
                        {
                            Id = 5L,
                            Apellido = "BENAGLIO",
                            EstaEliminado = (short)0,
                            Nombre = "HORACIO"
                        },
                        new
                        {
                            Id = 6L,
                            Apellido = "GIMENEZ",
                            EstaEliminado = (short)0,
                            Nombre = "NAZARENO"
                        },
                        new
                        {
                            Id = 7L,
                            Apellido = "VENTURINI",
                            EstaEliminado = (short)0,
                            Nombre = "ARTURO"
                        },
                        new
                        {
                            Id = 8L,
                            Apellido = "BAZA",
                            EstaEliminado = (short)0,
                            Nombre = "DAVID"
                        },
                        new
                        {
                            Id = 9L,
                            Apellido = "FRAU",
                            EstaEliminado = (short)0,
                            Nombre = "DANIEL"
                        },
                        new
                        {
                            Id = 10L,
                            Apellido = "ARGAÑARAZ",
                            EstaEliminado = (short)0,
                            Nombre = "CARMEN"
                        },
                        new
                        {
                            Id = 11L,
                            Apellido = "VALDE LICO",
                            EstaEliminado = (short)0,
                            Nombre = "GUILLERMO"
                        },
                        new
                        {
                            Id = 12L,
                            Apellido = "FERNANDEZ",
                            EstaEliminado = (short)0,
                            Nombre = "SILVIO"
                        },
                        new
                        {
                            Id = 13L,
                            Apellido = "QUIROGA",
                            EstaEliminado = (short)0,
                            Nombre = "ADRIAN"
                        },
                        new
                        {
                            Id = 14L,
                            Apellido = "JUAREZ",
                            EstaEliminado = (short)0,
                            Nombre = "PABLO"
                        },
                        new
                        {
                            Id = 15L,
                            Apellido = "FIGUEROA",
                            EstaEliminado = (short)0,
                            Nombre = "RICARDO"
                        },
                        new
                        {
                            Id = 16L,
                            Apellido = "LAZARTE",
                            EstaEliminado = (short)0,
                            Nombre = "JORGE"
                        },
                        new
                        {
                            Id = 17L,
                            Apellido = "GEREZ",
                            EstaEliminado = (short)0,
                            Nombre = "LILIANA"
                        },
                        new
                        {
                            Id = 18L,
                            Apellido = "NEME",
                            EstaEliminado = (short)0,
                            Nombre = "GRACIELA"
                        },
                        new
                        {
                            Id = 19L,
                            Apellido = "TOBIAS TERUEL",
                            EstaEliminado = (short)0,
                            Nombre = "OSCAR"
                        },
                        new
                        {
                            Id = 20L,
                            Apellido = "LOPEZ",
                            EstaEliminado = (short)0,
                            Nombre = "LORENA"
                        },
                        new
                        {
                            Id = 21L,
                            Apellido = "PERPIGNAL",
                            EstaEliminado = (short)0,
                            Nombre = "LUISA"
                        },
                        new
                        {
                            Id = 22L,
                            Apellido = "SILVA",
                            EstaEliminado = (short)0,
                            Nombre = "ENZO"
                        },
                        new
                        {
                            Id = 23L,
                            Apellido = "MENA",
                            EstaEliminado = (short)0,
                            Nombre = "VICENTE"
                        },
                        new
                        {
                            Id = 24L,
                            Apellido = "CANSECO",
                            EstaEliminado = (short)0,
                            Nombre = "RICARDO"
                        });
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.PrestadorEspecialidad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("EstaEliminado");

                    b.Property<long>("IdEspecialidad");

                    b.Property<long>("IdPrestador");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IdEspecialidad");

                    b.HasIndex("IdPrestador");

                    b.ToTable("PrestadorEspecialidades");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 1L,
                            IdPrestador = 1L
                        },
                        new
                        {
                            Id = 2L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 1L,
                            IdPrestador = 2L
                        },
                        new
                        {
                            Id = 3L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 2L,
                            IdPrestador = 3L
                        },
                        new
                        {
                            Id = 4L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 2L,
                            IdPrestador = 4L
                        },
                        new
                        {
                            Id = 5L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 3L,
                            IdPrestador = 5L
                        },
                        new
                        {
                            Id = 6L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 4L,
                            IdPrestador = 6L
                        },
                        new
                        {
                            Id = 7L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 5L,
                            IdPrestador = 7L
                        },
                        new
                        {
                            Id = 8L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 6L,
                            IdPrestador = 8L
                        },
                        new
                        {
                            Id = 9L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 7L,
                            IdPrestador = 9L
                        },
                        new
                        {
                            Id = 10L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 7L,
                            IdPrestador = 10L
                        },
                        new
                        {
                            Id = 11L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 8L,
                            IdPrestador = 11L
                        },
                        new
                        {
                            Id = 12L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 8L,
                            IdPrestador = 12L
                        },
                        new
                        {
                            Id = 13L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 8L,
                            IdPrestador = 13L
                        },
                        new
                        {
                            Id = 14L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 8L,
                            IdPrestador = 14L
                        },
                        new
                        {
                            Id = 15L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 9L,
                            IdPrestador = 15L
                        },
                        new
                        {
                            Id = 16L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 9L,
                            IdPrestador = 16L
                        },
                        new
                        {
                            Id = 17L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 10L,
                            IdPrestador = 17L
                        },
                        new
                        {
                            Id = 18L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 11L,
                            IdPrestador = 18L
                        },
                        new
                        {
                            Id = 19L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 11L,
                            IdPrestador = 19L
                        },
                        new
                        {
                            Id = 20L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 11L,
                            IdPrestador = 20L
                        },
                        new
                        {
                            Id = 21L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 12L,
                            IdPrestador = 21L
                        },
                        new
                        {
                            Id = 22L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 13L,
                            IdPrestador = 22L
                        },
                        new
                        {
                            Id = 23L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 5L,
                            IdPrestador = 23L
                        },
                        new
                        {
                            Id = 24L,
                            EstaEliminado = (short)0,
                            IdEspecialidad = 14L,
                            IdPrestador = 24L
                        });
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.PrestadorEstablecimiento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("EstaEliminado");

                    b.Property<long>("IdEstablecimiento");

                    b.Property<long>("IdPrestadorEspecialidad");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IdEstablecimiento");

                    b.HasIndex("IdPrestadorEspecialidad");

                    b.ToTable("PrestadorEstablecimientos");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 1L
                        },
                        new
                        {
                            Id = 2L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 2L
                        },
                        new
                        {
                            Id = 3L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 3L
                        },
                        new
                        {
                            Id = 4L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 4L
                        },
                        new
                        {
                            Id = 5L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 5L
                        },
                        new
                        {
                            Id = 6L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 6L
                        },
                        new
                        {
                            Id = 7L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 7L
                        },
                        new
                        {
                            Id = 8L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 8L
                        },
                        new
                        {
                            Id = 9L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 9L
                        },
                        new
                        {
                            Id = 10L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 10L
                        },
                        new
                        {
                            Id = 11L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 11L
                        },
                        new
                        {
                            Id = 12L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 12L
                        },
                        new
                        {
                            Id = 13L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 13L
                        },
                        new
                        {
                            Id = 14L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 14L
                        },
                        new
                        {
                            Id = 15L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 15L
                        },
                        new
                        {
                            Id = 16L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 16L
                        },
                        new
                        {
                            Id = 17L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 17L
                        },
                        new
                        {
                            Id = 18L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 18L
                        },
                        new
                        {
                            Id = 19L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 19L
                        },
                        new
                        {
                            Id = 20L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 20L
                        },
                        new
                        {
                            Id = 21L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 21L
                        },
                        new
                        {
                            Id = 22L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 22L
                        },
                        new
                        {
                            Id = 23L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 23L
                        },
                        new
                        {
                            Id = 24L,
                            EstaEliminado = (short)0,
                            IdEstablecimiento = 3L,
                            IdPrestadorEspecialidad = 24L
                        });
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.DiaHorario", b =>
                {
                    b.HasOne("Galenort.Dominio.Entidades.Dia", "Dia")
                        .WithMany("DiaHorarios")
                        .HasForeignKey("IdDia")
                        .HasConstraintName("FK_Dia_DiaHorarios")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Galenort.Dominio.Entidades.HorarioPrestador", "HorarioPrestador")
                        .WithMany("DiaHorarios")
                        .HasForeignKey("IdHorarioPrestador")
                        .HasConstraintName("FK_HorarioPrestador_DiaHorarios")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.Establecimiento", b =>
                {
                    b.HasOne("Galenort.Dominio.Entidades.Localidad", "Localidad")
                        .WithMany("Establecimientos")
                        .HasForeignKey("IdLocalidad")
                        .HasConstraintName("FK_Localidad_Establecimientos")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.HorarioPrestador", b =>
                {
                    b.HasOne("Galenort.Dominio.Entidades.PrestadorEstablecimiento", "PrestadorEstablecimiento")
                        .WithMany("HorarioPrestadores")
                        .HasForeignKey("IdPrestadorEstablecimiento")
                        .HasConstraintName("FK_PrestadorEstablecimiento_HorarioPrestadores")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.PrestadorEspecialidad", b =>
                {
                    b.HasOne("Galenort.Dominio.Entidades.Especialidad", "Especialidad")
                        .WithMany("PrestadorEspecialidades")
                        .HasForeignKey("IdEspecialidad")
                        .HasConstraintName("FK_Especialidad_PrestadorEspecialidad")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Galenort.Dominio.Entidades.Prestador", "Prestador")
                        .WithMany("PrestadorEspecialidades")
                        .HasForeignKey("IdPrestador")
                        .HasConstraintName("FK_Prestador_PrestadorEspecialidad")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.PrestadorEstablecimiento", b =>
                {
                    b.HasOne("Galenort.Dominio.Entidades.Establecimiento", "Establecimiento")
                        .WithMany("PrestadorEstablecimientos")
                        .HasForeignKey("IdEstablecimiento")
                        .HasConstraintName("FK_Establecimiento_PrestadorEstablecimientos")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Galenort.Dominio.Entidades.PrestadorEspecialidad", "PrestadorEspecialidad")
                        .WithMany("PrestadorEstablecimientos")
                        .HasForeignKey("IdPrestadorEspecialidad")
                        .HasConstraintName("FK_Prestador_PrestadorEstablecimientos")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
