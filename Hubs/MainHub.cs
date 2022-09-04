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
            //await Clients.All.ChangeFirst(state);
            //await Clients.All.ChangeSecond(state);
            //await Clients.All.ChangeThird(state);
            //await Clients.All.ChangeFourth(state);
            //await Clients.All.ChangeFifth(state);
            //await Clients.All.ChangeSixth(state);
            //await Clients.All.ChangeSeventh(state);
            //await Clients.All.ChangeEight(state);
            //await Clients.All.ChangeNinth(state);
            //await Clients.All.ChangeTenth(state);
            //await Clients.All.ChangeEleventh(state);
            //await Clients.All.ChangeTwelth(state);



            //await Clients.All.ChangeReportState(state);
        }
    }
}
