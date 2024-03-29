﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Galenort.Dominio.Entidades;
using Galenort.Dominio.Metadata;
using Microsoft.EntityFrameworkCore;
using static Galenort.Conexion.Conexion;

namespace Galenort.Infraestructura
{
    public class DataContext : DbContext
    {

        #region DbConfiguration

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ObtenerCadenaConexionSql,
                prov => prov.CommandTimeout(60)).EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            base.OnModelCreating(modelBuilder);

            #region Relations

            modelBuilder.Entity<Dia>()
                .HasMany(x => x.DiaHorarios)
                .WithOne(x => x.Dia)
                .HasForeignKey(x => x.IdDia)
                .HasConstraintName("FK_Dia_DiaHorarios").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Localidad>()
                .HasMany(x => x.Establecimientos)
                .WithOne(x => x.Localidad)
                .HasForeignKey(x => x.IdLocalidad)
                .HasConstraintName("FK_Localidad_Establecimientos").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DiaHorario>()
                .HasOne(x => x.Dia)
                .WithMany(x => x.DiaHorarios)
                .HasForeignKey(x => x.IdDia)
                .HasConstraintName("FK_Dia_DiaHorarios").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DiaHorario>()
                .HasOne(x => x.HorarioPrestador)
                .WithMany(x => x.DiaHorarios)
                .HasForeignKey(x => x.IdHorarioPrestador)
                .HasConstraintName("FK_HorarioPrestador_DiaHorarios").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HorarioPrestador>()
                .HasOne(x => x.PrestadorEstablecimiento)
                .WithMany(x => x.HorarioPrestadores)
                .HasForeignKey(x => x.IdPrestadorEstablecimiento)
                .HasConstraintName("FK_PrestadorEstablecimiento_HorarioPrestadores").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HorarioPrestador>()
                .HasMany(x => x.DiaHorarios)
                .WithOne(x => x.HorarioPrestador)
                .HasForeignKey(x => x.IdHorarioPrestador)
                .HasConstraintName("FK_HorarioPrestador_DiaHorarios").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Especialidad>()
                .HasMany(x => x.PrestadorEspecialidades)
                .WithOne(x => x.Especialidad)
                .HasForeignKey(x => x.IdEspecialidad)
                .HasConstraintName("FK_Especialidad_PrestadorEspecialidad").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Establecimiento>()
                .HasOne(x => x.Localidad)
                .WithMany(x => x.Establecimientos)
                .HasForeignKey(x => x.IdLocalidad)
                .HasConstraintName("FK_Localidad_Establecimientos").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PrestadorEspecialidad>()
                .HasOne(x => x.Prestador)
                .WithMany(x => x.PrestadorEspecialidades)
                .HasForeignKey(x => x.IdPrestador)
                .HasConstraintName("FK_Prestador_PrestadorEspecialidad").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PrestadorEspecialidad>()
                .HasOne(x => x.Especialidad)
                .WithMany(x => x.PrestadorEspecialidades)
                .HasForeignKey(x => x.IdEspecialidad)
                .HasConstraintName("FK_Especialidad_PrestadorEspecialidad").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Prestador>()
                .HasMany(x => x.PrestadorEspecialidades)
                .WithOne(x => x.Prestador)
                .HasForeignKey(x => x.IdPrestador)
                .HasConstraintName("FK_Prestador_PrestadorEspecialidad").OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<PrestadorEstablecimiento>()
                .HasOne(x => x.PrestadorEspecialidad)
                .WithMany(x => x.PrestadorEstablecimientos)
                .HasForeignKey(x => x.IdPrestadorEspecialidad)
                .HasConstraintName("FK_Prestador_PrestadorEstablecimientos").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PrestadorEstablecimiento>()
                .HasOne(x => x.Establecimiento)
                .WithMany(x => x.PrestadorEstablecimientos)
                .HasForeignKey(x => x.IdEstablecimiento)
                .HasConstraintName("FK_Establecimiento_PrestadorEstablecimientos").OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Establecimiento>()
                .HasMany(x => x.PrestadorEstablecimientos)
                .WithOne(x => x.Establecimiento)
                .HasForeignKey(x => x.IdEstablecimiento)
                .HasConstraintName("FK_Establecimiento_PrestadorEstablecimientos")
                .OnDelete(DeleteBehavior.Restrict).OnDelete(DeleteBehavior.Restrict);

            #endregion


            #region Configurations



            modelBuilder.ApplyConfiguration<Dia>(new DiaMetadata());
            modelBuilder.ApplyConfiguration<DiaHorario>(new DiaHorarioMetadata());
            modelBuilder.ApplyConfiguration<HorarioPrestador>(new HorarioPrestadorMetadata());
            modelBuilder.ApplyConfiguration<Especialidad>(new EspecialidadMetadata());
            modelBuilder.ApplyConfiguration<Establecimiento>(new EstablecimientoMetadata());
            modelBuilder.ApplyConfiguration<PrestadorEspecialidad>(new PrestadorEspecialidadMetadata());
            modelBuilder.ApplyConfiguration<Localidad>(new LocalidadMetadata());
            modelBuilder.ApplyConfiguration<PrestadorEstablecimiento>(new PrestadorEstablecimientoMetadata());
            modelBuilder.ApplyConfiguration<Prestador>(new PrestadorMetadata());

            #endregion

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entidad in ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Deleted
                            && x.OriginalValues.Properties
                                .Any(p => p.Name.Contains("EstaEliminado"))))
            {
                entidad.State = EntityState.Unchanged;
                entidad.CurrentValues["EstaEliminado"] = (Int16) 1;
            }

            return base.SaveChangesAsync();
        }
        #endregion


        #region DbSet
        public DbSet<Dia> Dias { get; set; }
        public DbSet<DiaHorario> DiaHorarios { get; set; }
        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<PrestadorEspecialidad> PrestadorEspecialidades { get; set; }
        public DbSet<HorarioPrestador> HorarioPrestadores { get; set; }
        public DbSet<PrestadorEstablecimiento> PrestadorEstablecimientos { get; set; }
        public DbSet<Establecimiento> Establecimientos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }

        #endregion

    }
}
