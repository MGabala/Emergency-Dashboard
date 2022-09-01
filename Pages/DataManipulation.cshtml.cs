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
            await context.Clients.All.SendAsync("changeAgencyState", "Niedostêpny");
            await context.Clients.All.SendAsync("changeReportState", "Rozpoznanie");
            //Thread.Sleep(5000);
            //await context.Clients.All.SendAsync("changeAgencyState", "W przygotowaniu");
            //Thread.Sleep(5000);
            //await context.Clients.All.SendAsync("changeAgencyState", "Gotowa");
            //Thread.Sleep(5000);
            //await context.Clients.All.SendAsync("changeReportState","Rozpoznanie");

        }
    }
}
