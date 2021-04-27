using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai.hroads.webApi.Domains;

#nullable disable

namespace senai.hroads.webApi.Contexts
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

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Habilidade> Habilidades { get; set; }
        public virtual DbSet<Intermediaria> Intermediarias { get; set; }
        public virtual DbSet<Personagen> Personagens { get; set; }
        public virtual DbSet<Tipo> Tipos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-OVJKG6T\\SQLEXPRESS; initial catalog=SENAI_HROADS_TARDE; user Id=sa; pwd=Ted16m12");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__Classes__60FFF801D8B16DFF");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.Classe)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidade)
                    .HasName("PK__Habilida__655F75282CD499F7");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.Property(e => e.Habilidade1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Habilidade");
            });

            modelBuilder.Entity<Intermediaria>(entity =>
            {
                entity.HasKey(e => e.IdIntermediaria)
                    .HasName("PK__Intermed__5709A00B58DA683E");

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

            modelBuilder.Entity<Personagen>(entity =>
            {
                entity.HasKey(e => e.IdPersonagem)
                    .HasName("PK__Personag__E175C72ED3740CBF");

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
                    .HasName("PK__Tipos__BDD0DFE12CCE5F96");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
