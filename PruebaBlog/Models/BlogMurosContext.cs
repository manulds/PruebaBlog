using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PruebaBlog.Models
{
    public partial class BlogMurosContext : DbContext
    {
        public BlogMurosContext()
        {
        }

        public BlogMurosContext(DbContextOptions<BlogMurosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comentarios> Comentarios { get; set; }
        public virtual DbSet<Publicaciones> Publicaciones { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Blogs;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comentarios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMENTARIOS");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaComentario)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Publicaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PUBLICACIONES");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.FechaPublicacion).HasColumnType("date");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USUARIOS");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
