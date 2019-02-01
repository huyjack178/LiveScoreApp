﻿namespace Score
{
    using Prism.Ioc;
    using Prism.Modularity;
    using Score.Views;
    using Score.ViewModels;
    using Score.Services;

    public class ScoreModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IScoreService, ScoreService>();
            containerRegistry.RegisterForNavigation<ScorePage, ScorePageViewModel>();
        }
    }
}