namespace IntroductionRest.FormulaOne.Ergast.Services.Constructors
{
    using System.Threading.Tasks;
    using Model.Constructor;

    public interface IConstructorService
    {
        Task<ConstructorTable> GetSeasonConstructorCollectionAsync(string season = "current");

        Task<ConstructorTable> GetAllConstructorCollectionAsync();
    }
}
