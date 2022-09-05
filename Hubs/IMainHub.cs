namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task ChangeAgencyState(int idRow,int id,string color, string state);
        Task UpdateReportTable(string name, string address, string city, string type, DateTime date, string status);
        Task ChangeReportState(int state);
        Task ViewCountUpdate(int viewCount);
    }
}
