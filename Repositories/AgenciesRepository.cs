using EmergencyDashboard.Data;
using EmergencyDashboard.Models;

using Microsoft.EntityFrameworkCore;

namespace EmergencyDashboard.Repositories
{
    public class AgenciesRepository : IAgenciesRepository
    {
        private IAgenciesRepository repository;
        public AgenciesRepository(IAgenciesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<AgenciesModel>> GetAllAgenciesAsync()
        {
            return await repository.GetAllAgenciesAsync();
        }
    }
}
