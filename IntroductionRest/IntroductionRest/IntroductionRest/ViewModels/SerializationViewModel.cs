﻿using IntroductionRest.FormulaOne.Ergast.Services.Standings;
using IntroductionRest.Models;
using IntroductionRest.Services.Rest;
using IntroductionRest.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionRest.ViewModels
{
    public class SerializationViewModel : ViewModelBase
    {
        // Services
        private IRestService _restService;
        private IStandingService _standingService;

        // Variables
        private ObservableCollection<DriverStanding> _standing;

        public SerializationViewModel(IRestService restService,
            IStandingService standingService)
        {
            _restService = restService;
            _standingService = standingService;
        }

        public ObservableCollection<DriverStanding> Standing
        {
            get { return _standing; }
            set
            {
                _standing = value;
                RaisePropertyChanged();
            }
        }

        public override async void OnAppearing(object navigationContext)
        {
            await LoadStandingsAsync();

            base.OnAppearing(navigationContext);
        }

        private async Task LoadStandingsAsync()
        {
            var result = await _restService.GetSeasonDriverStandingsCollectionAsync();
            //var result = await = _standingService.GetSeasonDriverStandingsCollectionAsync();

            Standing = new ObservableCollection<DriverStanding>();
            foreach (var standing in result.StandingsLists.First().DriverStandings)
            {
                Standing.Add(standing);
            }
        }
    }
}