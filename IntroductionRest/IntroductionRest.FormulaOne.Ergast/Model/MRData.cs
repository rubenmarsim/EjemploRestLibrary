using IntroductionRest.FormulaOne.Ergast.Model.Circuit;
using IntroductionRest.FormulaOne.Ergast.Model.Constructor;
using IntroductionRest.FormulaOne.Ergast.Model.Driver;

namespace IntroductionRest.FormulaOne.Ergast.Model
{
    using Race;

    public class MRData
    {
        public string Xmlns { get; set; }
        public string Series { get; set; }
        public string Url { get; set; }
        public string Limit { get; set; }
        public string Offset { get; set; }
        public string Total { get; set; }
        public RaceTable RaceTable { get; set; }
        public DriverTable DriverTable { get; set; }
        public ConstructorTable ConstructorTable { get; set; } 
        public CircuitTable CircuitTable { get; set; }
    }
}
