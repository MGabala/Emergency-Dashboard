using EmergencyDashboard.Hubs;

using Microsoft.AspNetCore.Mvc;

namespace EmergencyDashboard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private MainContext _context;
        private readonly IHubContext<MainHub> mainHub;
        public IEnumerable<AgenciesModel> Agencies { get; set; } = null!;

        public IndexModel(ILogger<IndexModel> logger, MainContext _context, IHubContext<MainHub> hubContext)
        {
            _logger = logger;
           mainHub = hubContext;
            this._context = _context;
        }

     public async Task OnGetAsync()
        {
            Agencies = await _context.Agencies.OrderBy(x => x.Id).ToListAsync();
        }
        public async Task OnPostStart()
        {
            await mainHub.Clients.All.SendAsync("ChangeStateTest", "state");
        }
    }
}