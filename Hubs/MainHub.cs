using System.Net;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

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
            
        }
        public async Task UpdateReportState(int id, string state,string color)
        {
            await Clients.All.ChangeReportState(id,state,color);
        }

        public async Task UpdateReportTable(string name, string address, string city, string type, string date, string status, int idRow)
        {
            await Clients.All.UpdateReportTable(name, address, city, type, date, status, idRow);
        }
    }
}
