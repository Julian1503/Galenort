﻿// <auto-generated />
using System;
using Galenort.Infraestructura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Galenort.Infraestructura.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Descripcion = "Lunes",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 2L,
                            Descripcion = "Martes",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 3L,
                            Descripcion = "Miercoles",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 4L,
                            Descripcion = "Jueves",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 5L,
                            Descripcion = "Viernes",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 6L,
                            Descripcion = "Sabado",
                            EstaEliminado = (short)0
                        },
                        new
                        {
                            Id = 7L,
                            Descripcion = "Domingo",
                            EstaEliminado = (short)0
                        });
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.DiaHorario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("EstaEliminado");

                    b.Property<long>("IdDia");

                    b.Property<long>("IdHorario");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IdDia");

                    b.HasIndex("IdHorario");

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
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.Establecimiento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<short>("EstaEliminado");

                    b.Property<string>("Localidad")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Establecimientos");
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.Horario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("EstaEliminado");

                    b.Property<TimeSpan>("HoraFin")
                        .HasColumnType("Time");

                    b.Property<TimeSpan>("HoraInicio")
                        .HasColumnType("Time");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.HorarioPrestador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("EstaEliminado");

                    b.Property<long>("IdEspecialidad");

                    b.Property<long>("IdEstablecimiento");

                    b.Property<long>("IdHorario");

                    b.Property<long>("IdPrestador");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IdEspecialidad");

                    b.HasIndex("IdEstablecimiento");

                    b.HasIndex("IdHorario");

                    b.HasIndex("IdPrestador");

                    b.ToTable("HorarioPrestadores");
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
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.PrestadorEstablecimiento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("EstaEliminado");

                    b.Property<long>("IdEstablecimiento");

                    b.Property<long>("IdPrestador");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IdEstablecimiento");

                    b.HasIndex("IdPrestador");

                    b.ToTable("PrestadorEstablecimientos");
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.DiaHorario", b =>
                {
                    b.HasOne("Galenort.Dominio.Entidades.Dia", "Dia")
                        .WithMany("DiaHorarios")
                        .HasForeignKey("IdDia")
                        .HasConstraintName("FK_Dia_DiaHorarios")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galenort.Dominio.Entidades.Horario", "Horario")
                        .WithMany("DiaHorarios")
                        .HasForeignKey("IdHorario")
                        .HasConstraintName("FK_Horario_DiaHorarios")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.HorarioPrestador", b =>
                {
                    b.HasOne("Galenort.Dominio.Entidades.Especialidad", "Especialidad")
                        .WithMany("HorarioPrestadores")
                        .HasForeignKey("IdEspecialidad")
                        .HasConstraintName("FK_Especialidad_HorarioPrestadores")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galenort.Dominio.Entidades.Establecimiento", "Establecimiento")
                        .WithMany("HorarioPrestadores")
                        .HasForeignKey("IdEstablecimiento")
                        .HasConstraintName("FK_Establecimiento_HorarioPrestadores")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galenort.Dominio.Entidades.Horario", "Horario")
                        .WithMany("HorarioPrestadores")
                        .HasForeignKey("IdHorario")
                        .HasConstraintName("FK_Horario_HorarioPrestadores")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galenort.Dominio.Entidades.Prestador", "Prestador")
                        .WithMany("HorarioPrestadores")
                        .HasForeignKey("IdPrestador")
                        .HasConstraintName("FK_Prestador_HorarioPrestadores")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.PrestadorEspecialidad", b =>
                {
                    b.HasOne("Galenort.Dominio.Entidades.Especialidad", "Especialidad")
                        .WithMany("PrestadorEspecialidades")
                        .HasForeignKey("IdEspecialidad")
                        .HasConstraintName("FK_Especialidad_PrestadorEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galenort.Dominio.Entidades.Prestador", "Prestador")
                        .WithMany("PrestadorEspecialidades")
                        .HasForeignKey("IdPrestador")
                        .HasConstraintName("FK_Prestador_PrestadorEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Galenort.Dominio.Entidades.PrestadorEstablecimiento", b =>
                {
                    b.HasOne("Galenort.Dominio.Entidades.Establecimiento", "Establecimiento")
                        .WithMany("PrestadorEstablecimientos")
                        .HasForeignKey("IdEstablecimiento")
                        .HasConstraintName("FK_Establecimiento_PrestadorEstablecimientos")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galenort.Dominio.Entidades.Prestador", "Prestador")
                        .WithMany("PrestadorEstablecimientos")
                        .HasForeignKey("IdPrestador")
                        .HasConstraintName("FK_Prestador_PrestadorEstablecimientos")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
