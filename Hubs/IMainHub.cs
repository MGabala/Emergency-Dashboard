namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task ChangeAgencyState(string state);
        Task ChangeReportState(string state);
        Task ChangeSpecificState( string state);
        Task ViewCountUpdate(int viewCount);
    }
}
