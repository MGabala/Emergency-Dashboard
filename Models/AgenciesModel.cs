namespace EmergencyDashboard.Models
{
    public class AgenciesModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
