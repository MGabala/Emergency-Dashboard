using System.Runtime.CompilerServices;

namespace EmergencyDashboard.Hubs
{
    public class MainHub : Hub<IMainHub>
    {
        private readonly MainContext context;

        public MainHub(MainContext context)
        {
            this.context = context;
        }
        public static int ViewCount { get; set; } = 0;
        public async override Task OnConnectedAsync()
        {
            ViewCount++;
            await Clients.All.ViewCountUpdate(ViewCount);
            await base.OnConnectedAsync();
        }
        public async override Task OnDisconnectedAsync(Exception? exception)
        {
            ViewCount--;
            await Clients.All.ViewCountUpdate(ViewCount);
            await base.OnDisconnectedAsync(exception);
        }
        public async Task UpdateState(string agencyState)
        {
            await Clients.All.ChangeAgencyState(agencyState);
            await Clients.All.ChangeReportState( agencyState);
            await Clients.All.ChangeSpecificState( agencyState);
        }
    }
}
