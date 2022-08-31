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
            await context.Clients.All.SendAsync("changeStateTest", "test");
        }
    }
}
