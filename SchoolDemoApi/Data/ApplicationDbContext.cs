using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolDemoApi.Data.Entities;

namespace SchoolDemoApi.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("AppUser");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.SchoolId);

                entity.Property(e => e.SchoolId)
                    .ValueGeneratedNever()
                    .HasColumnName("SchoolId");

                entity.Property(e => e.Bemis).HasColumnName("BEMIS");

                entity.Property(e => e.Blstep)
                    .HasColumnName("BLStep")
                    .HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.ClusterBemis).HasColumnName("ClusterBEMIS");

                entity.Property(e => e.IsIctlab)
                    .IsRequired()
                    .HasColumnName("IsICTLab")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsProjectFocused)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsScienceLab)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsSolar)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Uc).HasColumnName("UC");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section");
            });

            
            modelBuilder.Entity<StudentEnrollment>(entity =>
            {
                entity.HasKey(e => e.StudentEnrollmentId);

                entity.ToTable("StudentEnrollment");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolId");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.StudentEnrollments)
                    .HasForeignKey(d => d.SchoolId);
            });

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<StudentEnrollment> StudentEnrollments { get; set; }
        public DbSet<StudentEnrollmentDetail> StudentEnrollmentDetails { get; set; }
    }
}
