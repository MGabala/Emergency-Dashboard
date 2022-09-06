namespace EmergencyDashboard.Models
{
    public class Reports
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Time { get; set; } = null!;
        public string Status { get; set; } = null!;
    }
}
