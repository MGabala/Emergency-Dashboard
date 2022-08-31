namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task ChangeStateTest(string state);
        Task ViewCountUpdate(int viewCount);
    }
}
