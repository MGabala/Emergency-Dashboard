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
        public async override Task OnDisconnectedAsync(Exception exception)
        {
            ViewCount--;
            await Clients.All.ViewCountUpdate(ViewCount);
            await base.OnDisconnectedAsync(exception);
        }
        public async Task CheckStatus()
        {
            var lista = await context.Agencies.OrderBy(x => x.Status).ToListAsync();
            foreach(var x in lista)
            {
                await Clients.All.CheckStatus(x.Status);
            }
          
        }
    }
}
