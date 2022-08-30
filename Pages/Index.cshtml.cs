namespace EmergencyDashboard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private MainContext _context;
        public IEnumerable<AgenciesModel> Agencies { get; set; } = null!;

        public IndexModel(ILogger<IndexModel> logger, MainContext _context)
        {
            _logger = logger;
           
            this._context = _context;
        }

     public async Task OnGetAsync()
        {
            Agencies = await _context.Agencies.OrderBy(x => x.Id).ToListAsync();
        }
    }
}