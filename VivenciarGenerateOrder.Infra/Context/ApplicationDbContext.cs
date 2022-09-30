using Microsoft.EntityFrameworkCore;
using VivenciarGenerateOrder.Domain.Entities;
using VivenciarGenerateOrder.Infra.Map;

namespace VivenciarGenerateOrder.Infra.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=VivenciarGenerateOrder.db");
        }

        public DbSet<Professional> Professional { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProfessionalMap());
            builder.ApplyConfiguration(new PatientMap());
            builder.ApplyConfiguration(new SponsorMap());
            
            base.OnModelCreating(builder);
        }
    }
}
