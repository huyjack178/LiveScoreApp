﻿namespace LiveScoreApp.ViewModels
{
    using System.Collections.Generic;
    using Common.Settings;
    using Common.ViewModels;
    using LiveScoreApp.Models;
    using LiveScoreApp.Services;
    using Prism.Commands;
    using Prism.Navigation;

    public class NavigationTitleViewViewModel : ViewModelBase
    {
        private string currentSportName;
        private IEnumerable<SportItem> sportItems;
        private readonly ISportService sportService;

        public string CurrentSportName
        {
            get { return currentSportName; }
            set { SetProperty(ref currentSportName, value); }
        }

        public DelegateCommand SelectSportCommand { get; set; }

        public NavigationTitleViewViewModel(INavigationService navigationService, ISportService sportService)
            : base(navigationService)
        {
            this.sportService = sportService;
            SelectSportCommand = new DelegateCommand(NavigateSelectSportPage);
        }

        public override void OnAppearing()
        {
            CurrentSportName = Settings.CurrentSportName;
            sportItems = sportService.GetSportItems();

            foreach (var sportItem in sportItems)
            {
                sportItem.IsVisible = sportItem.Id == Settings.CurrentSportId;
            }
        }

        private async void NavigateSelectSportPage()
        {
            var parameters = new NavigationParameters
            {
                { nameof(sportItems), sportItems }
            };

            await NavigationService.NavigateAsync("NavigationPage/SelectSportPage", parameters, useModalNavigation: true);
        }
    }
}