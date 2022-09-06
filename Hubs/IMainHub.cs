namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task ChangeAgencyState(int idRow,int id,string color, string state);
        Task UpdateReportTable(string name, string address, string city, string type, string date, string status, int idRow);
        Task ChangeReportState(int id,string state, string color);
        Task ViewCountUpdate(int viewCount);
    }
}
