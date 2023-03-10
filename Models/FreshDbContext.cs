using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FreshAPI.Models
{
    public partial class FreshDbContext : DbContext
    {
        public FreshDbContext()
        {
        }

        public FreshDbContext(DbContextOptions<FreshDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Certification> Certifications { get; set; } = null!;
        public virtual DbSet<Education> Educations { get; set; } = null!;
        public virtual DbSet<Experience> Experiences { get; set; } = null!;
        public virtual DbSet<Hobby> Hobbies { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Reference> References { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=LAPTOP-65NMLFNA\\SQLEXPRESS;Database=FreshDb;Trusted_Connection=true;Encrypt=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certification>(entity =>
            {
                entity.Property(e => e.CertificationId).HasColumnName("certification_id");

                entity.Property(e => e.CertificationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certification_name");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("person_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Certifications)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Certifica__perso__46E78A0C");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("Education");

                entity.Property(e => e.EducationId).HasColumnName("education_id");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("degree_name");

                entity.Property(e => e.EndYear)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("end_year");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("person_id");

                entity.Property(e => e.QualificationType)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("qualification_type");

                entity.Property(e => e.StartYear).HasColumnName("start_year");

                entity.Property(e => e.Summary)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("summary");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Education__summa__38996AB5");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.ToTable("Experience");

                entity.Property(e => e.ExperienceId).HasColumnName("experience_id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.EndYear)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("end_year");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("job_title");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("person_id");

                entity.Property(e => e.StartYear).HasColumnName("start_year");

                entity.Property(e => e.Summary)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("summary");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Experienc__perso__3B75D760");
            });

            modelBuilder.Entity<Hobby>(entity =>
            {
                entity.Property(e => e.HobbyId).HasColumnName("hobby_id");

                entity.Property(e => e.HobbyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hobby_name");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("person_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Hobbies)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Hobbies__person___49C3F6B7");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("language_name");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("person_id");

                entity.Property(e => e.Proficiency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("proficiency");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Languages)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Languages__profi__412EB0B6");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("person_id");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contact_number");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.Github)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("github");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.ToTable("Reference");

                entity.Property(e => e.ReferenceId).HasColumnName("reference_id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contact_number");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("person_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.References)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reference__perso__3E52440B");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("person_id");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("skill_name");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Skills__person_i__440B1D61");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
