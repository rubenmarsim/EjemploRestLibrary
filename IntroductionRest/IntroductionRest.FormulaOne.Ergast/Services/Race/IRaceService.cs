namespace IntroductionRest.FormulaOne.Ergast.Services.Race
{
    using System.Threading.Tasks;
    using Model.Race;

    public interface IRaceService
    {    
        Task<RaceTable> GetSeasonScheduleCollectionAsync(string season = "current");
    }
}
