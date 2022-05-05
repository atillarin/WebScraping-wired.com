using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TestMaker.Entity.Concrete.Model;

#nullable disable

namespace TestMaker.Dal.Concrete.EntityFramework.Context
{
    public partial class defaultContext : DbContext
    {
        public defaultContext()
        {
        }

        public defaultContext(DbContextOptions<defaultContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {       //appsettings.json dosyasında startup üzerinden okunuyor.
                    //optionsBuilder.UseSqlite("DataSource=C:\\Users\\Administrator\\source\\repos\\TestMaker\\default.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Question1)
                    .IsRequired()
                    .HasColumnName("Question");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.Date)
                    .IsRequired();

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserName).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
