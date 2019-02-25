namespace IntroductionRest.FormulaOne.Ergast.Services.Circuits
{
    using System.Threading.Tasks;
    using Model.Circuit;

    public interface ICircuitService
    {   
        Task<CircuitTable> GetSeasonCircuitsCollectionAsync(string season = "current");

        Task<CircuitTable> GetAllCircuitsCollectionAsync();
    }
}
