namespace EmergencyDashboard.Repositories
{
    public class AgenciesRepository : IAgenciesRepository
    {
        private IAgenciesRepository repository;
        private MainContext _context;
        public AgenciesRepository(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AgenciesModel>> GetAllAgenciesAsync()
        {
            return await _context.Agencies.OrderBy(x => x.Id).ToListAsync();
        }
    }
}
