namespace EmergencyDashboard.Hubs
{
    public interface IMainHub
    {
        Task ChangeAgencyState(int idRow,int id,string color, string state);
        Task ChangeFirst(int state);
        Task ChangeSecond(int state);
        Task ChangeThird(int state);
        Task ChangeFourth(int state);
        Task ChangeFifth(int state);
        Task ChangeSixth(int state);
        Task ChangeSeventh(int state);
        Task ChangeEight(int state);
        Task ChangeNinth(int state);
        Task ChangeTenth(int state);
        Task ChangeEleventh(int state);
        Task ChangeTwelth(int state);
        Task ChangeReportState(int state);
        Task ViewCountUpdate(int viewCount);
    }
}
