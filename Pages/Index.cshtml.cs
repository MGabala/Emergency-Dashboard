using EmergencyDashboard.Data;
using EmergencyDashboard.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmergencyDashboard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private MainContext _context;
        public IEnumerable<AgenciesModel> Agencies { get; set; } = null!;

        public IndexModel(ILogger<IndexModel> logger, MainContext context)
        {
            _logger = logger;
            _context = context;
        }

     public async Task OnGetAsync()
        {
            Agencies = _context.Agencies.OrderBy(x => x.Id);
        }
    }
}