using KTMPos.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace KTMPos.DAL.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Login> Logins { get; set; }    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding garna ko lagi kaam laagne method.
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
