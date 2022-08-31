namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task changeAgencyState(int id, string state);
        Task ViewCountUpdate(int viewCount);
    }
}
