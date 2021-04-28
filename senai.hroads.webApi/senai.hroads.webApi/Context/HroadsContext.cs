using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai.hroads.webApi.Domains;

#nullable disable

namespace senai.hroads.webApi.Context
{
    public partial class HroadsContext : DbContext
    {
        public HroadsContext()
        {
        }

        public HroadsContext(DbContextOptions<HroadsContext> options)
            : base(options) 
        {
        }

        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Habilidade> Habilidades { get; set; }
        public virtual DbSet<Intermediaria> Intermediarias { get; set; }
        public virtual DbSet<Personagens> Personagens { get; set; }
        public virtual DbSet<Tipo> Tipos { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-OVJKG6T\\SQLEXPRESS; initial catalog=SENAI_HROADS_TARDE; user Id=sa; pwd=Ted16m12");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Classes>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__Classes__60FFF801C3053855");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.Classe)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidade)
                    .HasName("PK__Habilida__655F7528A8823DD9");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.Property(e => e.Habilidade1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Habilidade");
            });

            modelBuilder.Entity<Intermediaria>(entity =>
            {
                entity.HasKey(e => e.IdIntermediaria)
                    .HasName("PK__Intermed__5709A00B6DCFA1B3");

                entity.Property(e => e.IdIntermediaria).HasColumnName("idIntermediaria");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Intermediaria)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Intermedi__idCla__3D5E1FD2");

                entity.HasOne(d => d.IdHabilidadeNavigation)
                    .WithMany(p => p.Intermediaria)
                    .HasForeignKey(d => d.IdHabilidade)
                    .HasConstraintName("FK__Intermedi__idHab__3E52440B");
            });

            modelBuilder.Entity<Personagens>(entity =>
            {
                entity.HasKey(e => e.IdPersonagem)
                    .HasName("PK__Personag__E175C72EF1C3FFDC");

                entity.Property(e => e.IdPersonagem).HasColumnName("idPersonagem");

                entity.Property(e => e.CapacidadeMaximadeMana)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadeMaximadeVida)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DatadeAtualizacao).HasColumnType("date");

                entity.Property(e => e.DatadeCriacao).HasColumnType("date");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Personagens)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Personage__idCla__38996AB5");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__Tipos__BDD0DFE140048C80");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.Property(e => e.Tipo1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Tipo");

                entity.HasOne(d => d.IdHabilidadeNavigation)
                    .WithMany(p => p.Tipos)
                    .HasForeignKey(d => d.IdHabilidade)
                    .HasConstraintName("FK__Tipos__idHabilid__412EB0B6");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TipoUsua__03006BFFD5479604");

                entity.ToTable("TipoUsuario");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.TipoUsuario1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A6C917733E");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Senha)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuario__idTipoU__45F365D3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
