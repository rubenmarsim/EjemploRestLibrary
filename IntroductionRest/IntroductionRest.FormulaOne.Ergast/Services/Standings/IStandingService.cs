namespace IntroductionRest.FormulaOne.Ergast.Services.Standings
{
    using System.Threading.Tasks;
    using Model.Standing;

    public interface IStandingService
    {
        Task<StandingTable> GetSeasonConstructorStandingsCollectionAsync(string season = "current");

        Task<StandingTable> GetSeasonDriverStandingsCollectionAsync(string season = "current");
    }
}
