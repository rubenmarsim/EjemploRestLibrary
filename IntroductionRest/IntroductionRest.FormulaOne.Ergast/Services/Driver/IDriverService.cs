namespace IntroductionRest.FormulaOne.Ergast.Services.Driver
{
    using System.Threading.Tasks;
    using Model.Driver;
    using Model.Race;

    public interface IDriverService
    {
        Task<DriverTable> GetDriverCollectionAsync(string season = "current");

        Task<DriverTable> GetDriverInformationAsync(string driver = "");

        Task<DriverTable> GetChampionCollectionAsync();

        Task<RaceTable> GetDriverResultsAsync(string driver = "", string season = "current");
    }
}
