using EmergencyDashboard.Models;

using Microsoft.EntityFrameworkCore;

namespace EmergencyDashboard.Data
{
    public class MainContext : DbContext
    {
        public DbSet<AgenciesModel> Agencies { get; set; } = null!;
        public MainContext(DbContextOptions<MainContext> options) : base(options) 
        {

        }
    }
}
