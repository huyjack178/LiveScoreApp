﻿using System;
using Xamarin.Forms;

namespace Setting.Views
{
    public partial class DefaultSportPage : ContentPage
    {
        public DefaultSportPage()
        {
            InitializeComponent();
        }

        private async void OnClickDoneButton(object sender, EventArgs args) => await Navigation.PopModalAsync();
    }
}