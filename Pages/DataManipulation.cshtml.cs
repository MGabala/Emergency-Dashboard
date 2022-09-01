using EmergencyDashboard.Hubs;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmergencyDashboard.Pages
{
     public class DataManipulationModel : PageModel
    {
        private readonly IHubContext<MainHub> context;
        

        public DataManipulationModel(IHubContext<MainHub> _context)
        {
            context = _context;
          
        }
        public void OnGet()
        {
        }
        public async Task OnPostStart()
        {
            //Update only first element. Need to scale it to randomly change state for all records.
           await context.Clients.All.SendAsync("changeAgencyState","3", "Aktywna");
            //await context.Clients.All.SendAsync("changeFirst", "Aktywna1");
            //await context.Clients.All.SendAsync("changeSecond", "Aktywna2");//
            //await context.Clients.All.SendAsync("changeThird", "Aktywna3");
            //await context.Clients.All.SendAsync("changeFourth", "Aktywna4");
            //await context.Clients.All.SendAsync("changeFifth", "Aktywna5");//
            //await context.Clients.All.SendAsync("changeSixth", "Aktywna5");
            //await context.Clients.All.SendAsync("changeSeventh", "Aktywna5");
            //await context.Clients.All.SendAsync("changeEight", "Aktywna5");//
            //await context.Clients.All.SendAsync("changeNinth", "Aktywna5");
            //await context.Clients.All.SendAsync("changeTenth", "Aktywna5");
            //await context.Clients.All.SendAsync("changeEleventh", "Aktywna5");//
            //await context.Clients.All.SendAsync("changeTwelth", "Aktywna5");//


            //await context.Clients.All.SendAsync("changeReportState", "Rozpoznanie");
           // await StartShow();
        }

        private async Task StartShow()
        {
            await context.Clients.All.SendAsync("changeSecond", "Aktywna");
            Thread.Sleep(3000);
            await context.Clients.All.SendAsync("changeEigth", "Nieaktywna");
            Thread.Sleep(1000);
            await context.Clients.All.SendAsync("changeReportState", "Przyjête w centrali");
            Thread.Sleep(2500);
            await context.Clients.All.SendAsync("changeFourth", "Zmiana warty");
            Thread.Sleep(1800);
            await context.Clients.All.SendAsync("changeFifth", "Gotowa");
            Thread.Sleep(2000);
            await context.Clients.All.SendAsync("changeReportState", "Przekazane oddzia³owi");
            Thread.Sleep(1200);
            await context.Clients.All.SendAsync("changeSecond", "W terenie");
            Thread.Sleep(2100);
            await context.Clients.All.SendAsync("changeFirst", "Aktywna");
            Thread.Sleep(3000);
            await context.Clients.All.SendAsync("changeReportState", "Rozpoznanie");
            Thread.Sleep(2100);
            await context.Clients.All.SendAsync("changeSixth", "W akcji");
            Thread.Sleep(1200);
            await context.Clients.All.SendAsync("changeReportState", "Powrót jednostki");
            Thread.Sleep(2000);
            await context.Clients.All.SendAsync("changeReportState", "Zg³oszenie zakoñczone");
        }
    }
}
