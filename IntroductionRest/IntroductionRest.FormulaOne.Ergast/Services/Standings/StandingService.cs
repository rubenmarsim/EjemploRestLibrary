namespace IntroductionRest.FormulaOne.Ergast.Services.Standings
{
    using System.Threading.Tasks;
    using System;
    using System.Net;
    using Model.Standing;
    using Newtonsoft.Json;
    using Base;

    public class StandingService : HttpWebBase, IStandingService
    {
        public async Task<StandingTable> GetSeasonConstructorStandingsCollectionAsync(string season = "current")
        {
            StandingRootObject data = null;
            var url = string.Format("http://ergast.com/api/f1/{0}/constructorStandings.json", season);

            HttpWebRequest request = WebRequest.CreateHttp(new Uri(url));
            var response = await HttpRequest(request);
            if (response != null)
                data = JsonConvert.DeserializeObject<StandingRootObject>(response);

            return data != null ? data.MRData.StandingsTable : null;
        }

        public async Task<StandingTable> GetSeasonDriverStandingsCollectionAsync(string season = "current")
        {
            StandingRootObject data = null;
            var url = string.Format("http://ergast.com/api/f1/{0}/driverStandings.json", season);

            HttpWebRequest request = WebRequest.CreateHttp(new Uri(url));
            var response = await HttpRequest(request);
            if (response != null)
                data = JsonConvert.DeserializeObject<StandingRootObject>(response);

            return data != null ? data.MRData.StandingsTable : null;
        }
    }
}