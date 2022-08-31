namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task ChangeAgencyState(int id, string state);
        Task ChangeReportState(int id, string state);
        Task ViewCountUpdate(int viewCount);
    }
}
