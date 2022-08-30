using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmergencyDashboard.Pages
{
    public class DataManipulationModel : PageModel
    {
        private readonly MainContext context;

        public DataManipulationModel(MainContext context)
        {
            this.context = context;
        }
        public async Task OnPostChangeState()
        {

        }

    }
}
