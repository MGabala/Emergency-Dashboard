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
        public async Task UpdateState(int idRow,int id,string color, string state)
        {
            await Clients.All.ChangeAgencyState(idRow,id,color,state);
            //await Clients.All.ChangeReportState(state);
        }
        public async Task UpdateReportTable(string name, string address, string city, string type, DateTime date, string status)
        {
            await Clients.All.UpdateReportTable(name,address,city,type,date.Date,status);
        }
    }
}
