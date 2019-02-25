using System.Collections.Generic;

namespace IntroductionRest.FormulaOne.Ergast.Model.Standing
{
    public class StandingTable
    {
        public string Season { get; set; }
        public List<StandingList> StandingsLists { get; set; }
    }
}
