using System.Collections.Generic;

namespace IntroductionRest.FormulaOne.Ergast.Model.Race
{
    public class RaceTable
    {
        public string Season { get; set; }
        public List<Race> Races { get; set; }
    }
}
