using Microsoft.EntityFrameworkCore;

namespace HealthMonitorApp.Models
{
    public class HealthMonitorDbContext : DbContext
    {
        // Constructor accepting DbContextOptions for dependency injection
        public HealthMonitorDbContext(DbContextOptions<HealthMonitorDbContext> options)
            : base(options)
        {
        }

        public DbSet<HealthRecord> HealthRecords { get; set; }
    }
}
