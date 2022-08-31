namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task ChangeStateTest(int id, string state);
        Task ViewCountUpdate(int viewCount);
    }
}
