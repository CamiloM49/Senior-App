using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class IntegracionContext : DbContext
    {
        public IntegracionContext()
        {
        }

        public IntegracionContext(DbContextOptions<IntegracionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Apoderado> Apoderados { get; set; }
        public virtual DbSet<Comuna> Comunas { get; set; }
        public virtual DbSet<Cuentum> Cuenta { get; set; }
        public virtual DbSet<LastLocation> LastLocations { get; set; }
        public virtual DbSet<Portador> Portadors { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Regione> Regiones { get; set; }
        public virtual DbSet<RegistroPerdidum> RegistroPerdida { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.0.100;Database=Integracion;User=SA;password=CC4WzmYC@j3JPf$x");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Apoderado>(entity =>
            {
                entity.HasKey(e => e.IdApoderado)
                    .HasName("PK__apoderad__6302E8191487361B");

                entity.ToTable("apoderado");

                entity.Property(e => e.IdApoderado)
                    .ValueGeneratedNever()
                    .HasColumnName("id_apoderado");

                entity.Property(e => e.Apdmat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("apdmat");

                entity.Property(e => e.Apdpat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("apdpat");

                entity.Property(e => e.ComunaId).HasColumnName("comuna_id");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("direccion");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Membresia)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("membresia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("phone");

                entity.Property(e => e.Rut)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("rut");

                entity.HasOne(d => d.Comuna)
                    .WithMany(p => p.Apoderados)
                    .HasForeignKey(d => d.ComunaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_apoderado_comunas");

                entity.HasOne(d => d.IdApoderadoNavigation)
                    .WithOne(p => p.Apoderado)
                    .HasForeignKey<Apoderado>(d => d.IdApoderado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_apoderado_cuenta");
            });

            modelBuilder.Entity<Comuna>(entity =>
            {
                entity.ToTable("comunas");

                entity.HasIndex(e => e.ProvinciaId, "IX_Fk_comunas_provincias");

                entity.Property(e => e.ComunaId)
                    .ValueGeneratedNever()
                    .HasColumnName("comuna_id");

                entity.Property(e => e.ComunaNombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("comuna_nombre");

                entity.Property(e => e.ProvinciaId).HasColumnName("provincia_id");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Comunas)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_comunas_provincias");
            });

            modelBuilder.Entity<Cuentum>(entity =>
            {
                entity.HasKey(e => e.IdApoderado);

                entity.ToTable("cuenta");

                entity.Property(e => e.IdApoderado).HasColumnName("id_apoderado");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Passwd)
                    .IsRequired()
                    .HasColumnName("passwd");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.TipoCuenta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipo_cuenta")
                    .IsFixedLength(true);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<LastLocation>(entity =>
            {
                entity.HasKey(e => e.IdPerdida);

                entity.ToTable("last_location");

                entity.HasIndex(e => e.IdPortador, "IX_FK_last_location_portador");

                entity.Property(e => e.IdPerdida)
                    .ValueGeneratedNever()
                    .HasColumnName("id_perdida");

                entity.Property(e => e.AlertaActiva)
                    .HasMaxLength(255)
                    .HasColumnName("alerta_activa");

                entity.Property(e => e.AuthIp)
                    .HasMaxLength(255)
                    .HasColumnName("auth_ip");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.HoraLectura)
                    .HasColumnType("datetime")
                    .HasColumnName("hora_lectura");

                entity.Property(e => e.IdPortador).HasColumnName("id_portador");

                entity.Property(e => e.IpLectura)
                    .HasMaxLength(255)
                    .HasColumnName("ip_lectura");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.HasOne(d => d.IdPortadorNavigation)
                    .WithMany(p => p.LastLocations)
                    .HasForeignKey(d => d.IdPortador)
                    .HasConstraintName("FK_last_location_portador");
            });

            modelBuilder.Entity<Portador>(entity =>
            {
                entity.HasKey(e => e.IdPortador);

                entity.ToTable("portador");

                entity.HasIndex(e => e.IdApoderado, "IX_FK_portador_apoderado");

                entity.Property(e => e.IdPortador).HasColumnName("id_portador");

                entity.Property(e => e.Alergias)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("alergias");

                entity.Property(e => e.Apdmat)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("apdmat");

                entity.Property(e => e.Apdpat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("apdpat");

                entity.Property(e => e.ContactoEmergencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("contacto_emergencia");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.Enfermedades)
                    .IsRequired()
                    .HasColumnName("enfermedades");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.IdApoderado).HasColumnName("id_apoderado");

                entity.Property(e => e.MedicamentosPrescritos)
                    .IsRequired()
                    .HasColumnName("medicamentos_prescritos");

                entity.Property(e => e.MedicoCabecera)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("medico_cabecera");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Prevision).HasColumnName("prevision");

                entity.Property(e => e.PrevisionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("prevision_name");

                entity.Property(e => e.Rut)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("rut");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdApoderadoNavigation)
                    .WithMany(p => p.Portadors)
                    .HasForeignKey(d => d.IdApoderado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_portador_apoderado");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.ToTable("provincias");

                entity.HasIndex(e => e.RegionId, "IX_Fk_provincias_regiones");

                entity.Property(e => e.ProvinciaId)
                    .ValueGeneratedNever()
                    .HasColumnName("provincia_id");

                entity.Property(e => e.ProvinciaNombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("provincia_nombre");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_provincias_regiones");
            });

            modelBuilder.Entity<Regione>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("regiones");

                entity.Property(e => e.RegionId)
                    .ValueGeneratedNever()
                    .HasColumnName("region_id");

                entity.Property(e => e.RegionNombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("region_nombre");

                entity.Property(e => e.RegionOrdinal)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("region_ordinal");
            });

            modelBuilder.Entity<RegistroPerdidum>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("registro_perdida");

                entity.HasIndex(e => e.IdPortador, "IX_FK_registro_perdida_portador");

                entity.Property(e => e.IdRegistro)
                    .ValueGeneratedNever()
                    .HasColumnName("id_registro");

                entity.Property(e => e.AlertaConfirmada)
                    .HasMaxLength(1)
                    .HasColumnName("alerta_confirmada")
                    .IsFixedLength(true);

                entity.Property(e => e.Detalles).HasColumnName("detalles");

                entity.Property(e => e.EnviadoAuth)
                    .HasMaxLength(1)
                    .HasColumnName("enviado_auth")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoAlerta)
                    .HasMaxLength(1)
                    .HasColumnName("estado_alerta")
                    .IsFixedLength(true);

                entity.Property(e => e.HoraPerdida)
                    .HasColumnType("datetime")
                    .HasColumnName("hora_perdida");

                entity.Property(e => e.IdApoderado).HasColumnName("id_apoderado");

                entity.Property(e => e.IdPortador).HasColumnName("id_portador");

                entity.Property(e => e.Imagen).HasColumnName("imagen");

                entity.Property(e => e.IpApoderado).HasColumnName("ip_apoderado");

                entity.Property(e => e.LastLocation)
                    .HasMaxLength(255)
                    .HasColumnName("last_location");

                entity.HasOne(d => d.IdPortadorNavigation)
                    .WithMany(p => p.RegistroPerdida)
                    .HasForeignKey(d => d.IdPortador)
                    .HasConstraintName("FK_registro_perdida_portador");
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.HasKey(e => e.IdToken);

                entity.ToTable("token");

                entity.HasIndex(e => e.IdPortador, "IX_FK_token_portador");

                entity.Property(e => e.IdToken).HasColumnName("id_token");

                entity.Property(e => e.IdPortador).HasColumnName("id_portador");

                entity.Property(e => e.TokenId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("token_id");

                entity.Property(e => e.Valido).HasColumnName("valido");

                entity.HasOne(d => d.IdPortadorNavigation)
                    .WithMany(p => p.Tokens)
                    .HasForeignKey(d => d.IdPortador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_token_portador");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
