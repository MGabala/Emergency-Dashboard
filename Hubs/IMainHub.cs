namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task ChangeStateTest(int agencyId, string state);
        Task ViewCountUpdate(int viewCount);
    }
}
