namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task ViewCountUpdate(int viewCount);
        Task CheckStatus(string status);
        
    }
}
