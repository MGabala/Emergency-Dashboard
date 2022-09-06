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
          // ShowStart();
            await context.Clients.All.SendAsync("changeReportState",1, "Rozpoznanie");
        }

        private async Task ShowStart()
        {
            await context.Clients.All.SendAsync("changeAgencyState", "10", "10", "green", "Aktywna");
            Thread.Sleep(2000);
            await context.Clients.All.SendAsync("changeAgencyState", "7", "7", "green", "Aktywna");
            Thread.Sleep(1500);
            await context.Clients.All.SendAsync("changeAgencyState", "4", "4", "green", "Aktywna");
            Thread.Sleep(2500);
            await context.Clients.All.SendAsync("changeAgencyState", "12", "12", "red", "Nieaktywna");
            Thread.Sleep(950);
            await context.Clients.All.SendAsync("updateReportTable", "Stra¿ po¿arna", "Szeroka 15", "Kraków", "Po¿ar", "2022-08-31 15:45", "Nowe zg³oszenie", 2);
            Thread.Sleep(1500);
            await context.Clients.All.SendAsync("changeAgencyState", "10", "10", "orange", "W terenie");
            Thread.Sleep(2000);
            await context.Clients.All.SendAsync("changeAgencyState", "12", "12", "green", "Aktywna");
            Thread.Sleep(550);
            await context.Clients.All.SendAsync("changeAgencyState", "12", "12", "orange", "W terenie");
            Thread.Sleep(999);
            await context.Clients.All.SendAsync("updateReportTable", "Pogotowie", "Krajowa 21", "Gdañsk", "Wypadek", "2022-08-31 11:45", "Nowe zg³oszenie", 3);
            Thread.Sleep(999);
            await context.Clients.All.SendAsync("changeAgencyState", "3", "3", "green", "Aktywna");
            Thread.Sleep(1666);
            await context.Clients.All.SendAsync("changeAgencyState", "7", "7", "red", "Nieaktywna");
            Thread.Sleep(1450);
            await context.Clients.All.SendAsync("changeAgencyState", "5", "5", "orange", "W terenie");
            Thread.Sleep(1000);
            await context.Clients.All.SendAsync("changeAgencyState", "10", "10", "green", "Aktywna");
            Thread.Sleep(1500);
            await context.Clients.All.SendAsync("updateReportTable", "Policja", "G³ówna 5", "Warszawa", "Kradzie¿", "2022-08-31 21:45", "Nowe zg³oszenie", 4);
            Thread.Sleep(1500);
            await context.Clients.All.SendAsync("changeAgencyState", "11", "11", "red", "Nieaktywna");
            Thread.Sleep(850);
            await context.Clients.All.SendAsync("changeAgencyState", "1", "1", "green", "Aktywna");
            Thread.Sleep(760);
            await context.Clients.All.SendAsync("changeAgencyState", "2", "2", "green", "Aktywna");
            Thread.Sleep(1050);
            await context.Clients.All.SendAsync("changeAgencyState", "1", "1", "orange", "W terenie");
            Thread.Sleep(1980);
            await context.Clients.All.SendAsync("changeAgencyState", "6", "6", "green", "Aktywna");
            Thread.Sleep(2500);
            await context.Clients.All.SendAsync("changeAgencyState", "8", "8", "orange", "W terenie");
            Thread.Sleep(750);
            await context.Clients.All.SendAsync("updateReportTable", "Stra¿ miejska", "Krañcowa 35", "Œroda Wlkp.", "W³uczêga", "2022-08-31 16:45", "Nowe zg³oszenie", 5);
            Thread.Sleep(750);
            await context.Clients.All.SendAsync("changeAgencyState", "9", "9", "orange", "W terenie");
            Thread.Sleep(1500);
            await context.Clients.All.SendAsync("changeAgencyState", "11", "11", "green", "Aktywna");
            Thread.Sleep(666);
            await context.Clients.All.SendAsync("changeAgencyState", "3", "3", "orange", "W terenie");
            Thread.Sleep(1000);
            await context.Clients.All.SendAsync("changeAgencyState", "8", "8", "green", "Aktywna");
            Thread.Sleep(1500);
            await context.Clients.All.SendAsync("changeAgencyState", "4", "4", "red", "Nieaktywna");
        }

        private async Task ReportState()
        {
            var report = new Reports();
            report.Name = "test1";
            report.City = "test2";
            report.Address = "test6";
            report.Type = "test4";
            report.Time = "test7";
            report.Status = "test6";
            for (int i = 0; i < 6; i++)
            {
                await context.Clients.All.SendAsync("updateReportTable", report);
            }
        }
    }
}
