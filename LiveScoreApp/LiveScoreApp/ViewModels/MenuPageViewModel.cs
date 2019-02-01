﻿using LiveScoreApp.Services;
using Prism.Commands;
using Prism.Navigation;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace LiveScoreApp.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        private Models.MenuItem selectedMenuItem;

        public ObservableCollection<Models.MenuItem> MenuItems { get; set; }

        public Models.MenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => SetProperty(ref selectedMenuItem, value);
        }

        public DelegateCommand NavigateCommand { get; }

        public MenuPageViewModel(INavigationService navigationService, IMenuService menuService)
            : base(navigationService)
        {
            MenuItems = new ObservableCollection<Models.MenuItem>(menuService.GetAll());
            NavigateCommand = new DelegateCommand(Navigate);
        }

        private async void Navigate()
        {
            await NavigationService.NavigateAsync(nameof(NavigationPage) + "/");
        }
    }
}