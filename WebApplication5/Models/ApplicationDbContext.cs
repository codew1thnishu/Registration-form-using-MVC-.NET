using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class ApplicationDbContext : DbContext
    {
        // The constructor accepts connection options configured in Program.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // This creates a "Registrations" table using your existing RegistrationModel structure
        public DbSet<RegistrationModel> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Since RegistrationModel doesn't have an explicit [Key] property,
            // we configure Email as the unique Primary Key for this table.
            modelBuilder.Entity<RegistrationModel>()
                .HasKey(r => r.Email);
        }
    }
}
