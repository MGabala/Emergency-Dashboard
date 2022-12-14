namespace EmergencyDashboard.Data
{
    public class MainContext : DbContext
    {
        public DbSet<AgenciesModel> Agencies { get; set; } = null!;
        public DbSet<Reports> Reports { get; set; } = null!;
        public MainContext(DbContextOptions<MainContext> options) : base(options) 
        {

        }
    }
}
