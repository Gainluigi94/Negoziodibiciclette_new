using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Models.Classi
{
    public partial class NegoziodibicicletteContext : DbContext
    {
        public NegoziodibicicletteContext()
        {
        }

        public NegoziodibicicletteContext(DbContextOptions<NegoziodibicicletteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acquisti> Acquistis { get; set; }
        public virtual DbSet<Bici> Bicis { get; set; }
        public virtual DbSet<Cartadicredito> Cartadicreditos { get; set; }
        public virtual DbSet<Indirizzo> Indirizzos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Regione> Regiones { get; set; }
        public virtual DbSet<Utente> Utentes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=188.125.96.245;user id=bluadmin;password=b1ll1ng;database=Prova;Persist Security Info=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Acquisti>(entity =>
            {
                entity.ToTable("Acquisti");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BiciId).HasColumnName("BiciID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.HasOne(d => d.Bici)
                    .WithMany(p => p.Acquistis)
                    .HasForeignKey(d => d.BiciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiciOrder");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Acquistis)
                    .HasForeignKey(d => new { d.PersonaId, d.Email })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona");
            });

            modelBuilder.Entity<Bici>(entity =>
            {
                entity.ToTable("Bici");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Modello)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cartadicredito>(entity =>
            {
                entity.ToTable("Cartadicredito");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.Scadenza).HasColumnType("date");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Cartadicreditos)
                    .HasForeignKey(d => new { d.PersonaId, d.Email })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cartadicredito__7EF6D905");
            });

            modelBuilder.Entity<Indirizzo>(entity =>
            {
                entity.ToTable("Indirizzo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cap).HasColumnName("CAP");

                entity.Property(e => e.Comune)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMUNE");

                entity.Property(e => e.Numerocivico).HasColumnName("NUMEROCIVICO");

                entity.Property(e => e.Trav)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRAV");

                entity.Property(e => e.Via)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VIA");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Email })
                    .HasName("PK_Person");

                entity.ToTable("Persona");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BiciId).HasColumnName("BiciID");

                entity.Property(e => e.Codicefiscale)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cognome)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nascita)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nazione)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sesso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bici)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.BiciId)
                    .HasConstraintName("FK__Persona__BiciID__7F2BE32F");
            });

            modelBuilder.Entity<Regione>(entity =>
            {
                entity.ToTable("Regione");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOME");
            });

            modelBuilder.Entity<Utente>(entity =>
            {
                entity.ToTable("Utente");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Passwordd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("passwordd");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Utentes)
                    .HasForeignKey(d => new { d.Username, d.Email })
                    .HasConstraintName("FK__Utente__13F1F5EB");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
