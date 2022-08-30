using EmergencyDashboard.Models;

namespace EmergencyDashboard.Repositories
{
    public interface IAgenciesRepository
    {
        public Task<IEnumerable<AgenciesModel>> GetAllAgenciesAsync();
    }
}
