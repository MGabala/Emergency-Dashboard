namespace EmergencyDashboard.HostedServices
{
    public class DataManipulationService : IHostedService, IDisposable
    {
        private readonly IHubContext<MainHub> hubContext;
        private readonly IAgenciesRepository agenciesRepository;
        public DataManipulationService(IHubContext<MainHub> hubContext, IAgenciesRepository agenciesRepository)
        {
            this.hubContext = hubContext;
            this.agenciesRepository = agenciesRepository;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
