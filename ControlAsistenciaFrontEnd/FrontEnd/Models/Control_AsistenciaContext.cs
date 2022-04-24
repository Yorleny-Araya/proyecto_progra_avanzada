using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FE.Wizzard.Models
{
    public partial class Control_AsistenciaContext : DbContext
    {
        public Control_AsistenciaContext()
        {
        }

        public Control_AsistenciaContext(DbContextOptions<Control_AsistenciaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Ausencia> Ausencia { get; set; }
        public virtual DbSet<Autenticacion> Autenticacion { get; set; }
        public virtual DbSet<BitacotaAccion> BitacotaAccion { get; set; }
        public virtual DbSet<BitacotaSesion> BitacotaSesion { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Sede> Sede { get; set; }
        public virtual DbSet<TipoAsistencia> TipoAsistencia { get; set; }
        public virtual DbSet<TipoAusencia> TipoAusencia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-D1A9ETJ6\\SQLEXPRESS;Database=Control_Asistencia;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asistencia>(entity =>
            {
                entity.HasKey(e => e.IdAsistencia)
                    .HasName("PK__Asistenc__4E1AB8946587F150");

                entity.Property(e => e.IdAsistencia).HasColumnName("idAsistencia");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Hora).HasColumnName("hora");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.IdTipoAsistencia).HasColumnName("idTipoAsistencia");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Asistencia)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Asistenci__idEmp__32E0915F");

                entity.HasOne(d => d.IdTipoAsistenciaNavigation)
                    .WithMany(p => p.Asistencia)
                    .HasForeignKey(d => d.IdTipoAsistencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Asistenci__idTip__33D4B598");
            });

            modelBuilder.Entity<Ausencia>(entity =>
            {
                entity.HasKey(e => e.IdAusencia)
                    .HasName("PK__Ausencia__789856669B8F65EA");

                entity.Property(e => e.IdAusencia).HasColumnName("idAusencia");

                entity.Property(e => e.CantDias).HasColumnName("cantDias");

                entity.Property(e => e.FechaFinal)
                    .HasColumnName("fechaFinal")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("date");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.IdTipoAusencia).HasColumnName("idTipoAusencia");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("motivo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Ausencia)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ausencia__idEmpl__36B12243");

                entity.HasOne(d => d.IdTipoAusenciaNavigation)
                    .WithMany(p => p.Ausencia)
                    .HasForeignKey(d => d.IdTipoAusencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ausencia__idTipo__37A5467C");
            });

            modelBuilder.Entity<Autenticacion>(entity =>
            {
                entity.HasKey(e => e.IdAutenticacion)
                    .HasName("PK__Autentic__C758C4561C998B54");

                entity.Property(e => e.IdAutenticacion).HasColumnName("idAutenticacion");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Autenticacion)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Autentica__idEmp__2F10007B");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Autenticacion)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Autentica__idRol__300424B4");
            });

            modelBuilder.Entity<BitacotaAccion>(entity =>
            {
                entity.HasKey(e => e.IdBitacotaAccion)
                    .HasName("PK__Bitacota__233A6F18DEE9D96C");

                entity.Property(e => e.IdBitacotaAccion).HasColumnName("idBitacotaAccion");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasColumnName("accion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Hora).HasColumnName("hora");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.BitacotaAccion)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BitacotaA__idEmp__3D5E1FD2");
            });

            modelBuilder.Entity<BitacotaSesion>(entity =>
            {
                entity.HasKey(e => e.IdBitacotaSesion)
                    .HasName("PK__Bitacota__DDD31CAF038B56A6");

                entity.Property(e => e.IdBitacotaSesion).HasColumnName("idBitacotaSesion");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Hora).HasColumnName("hora");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.BitacotaSesion)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BitacotaS__idEmp__3A81B327");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__Empleado__5295297C27765244");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.CantVacaciones).HasColumnName("cantVacaciones");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnName("correo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Huella).HasColumnName("huella");

                entity.Property(e => e.IdSede).HasColumnName("idSede");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasColumnName("primerApellido")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasColumnName("segundoApellido")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSedeNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdSede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado__idSede__2C3393D0");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__3C872F760503CF2D");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Rol1)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.HasKey(e => e.IdSede)
                    .HasName("PK__Sede__C5AF63D0B3930C2F");

                entity.Property(e => e.IdSede).HasColumnName("idSede");

                entity.Property(e => e.Sede1)
                    .IsRequired()
                    .HasColumnName("sede")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoAsistencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoAsistencia)
                    .HasName("PK__TipoAsis__FF9ADE894C729D45");

                entity.Property(e => e.IdTipoAsistencia).HasColumnName("idTipoAsistencia");

                entity.Property(e => e.TipoAsistencia1)
                    .IsRequired()
                    .HasColumnName("tipoAsistencia")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoAusencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoAusencia)
                    .HasName("PK__TipoAuse__DC463884CBE465C6");

                entity.Property(e => e.IdTipoAusencia).HasColumnName("idTipoAusencia");

                entity.Property(e => e.TipoAusencia1)
                    .IsRequired()
                    .HasColumnName("tipoAusencia")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
