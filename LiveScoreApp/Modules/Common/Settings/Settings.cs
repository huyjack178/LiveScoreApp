﻿namespace Common.Settings
{
    using System.Collections.Generic;
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;

    public static class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string CurrentSportName
        {
            get => AppSettings.GetValueOrDefault(nameof(CurrentSportName), "Soccer");
            set => AppSettings.AddOrUpdateValue(nameof(CurrentSportName), value);
        }

        public static int CurrentSportId
        {
            get => AppSettings.GetValueOrDefault(nameof(CurrentSportId), 1);
            set => AppSettings.AddOrUpdateValue(nameof(CurrentSportId), value);
        }

        public static string CurrentLanguage
        {
            get => AppSettings.GetValueOrDefault(nameof(CurrentLanguage), "en-US");
            set => AppSettings.AddOrUpdateValue(nameof(CurrentLanguage), value);
        }

        public static string BaseSportRadarEndPoint
        {
            get => AppSettings.GetValueOrDefault(nameof(BaseSportRadarEndPoint), "https://api.sportradar.us");
            set => AppSettings.AddOrUpdateValue(nameof(BaseSportRadarEndPoint), value);
        }

        public static string SportRadarApiKey
        {
            get => AppSettings.GetValueOrDefault(nameof(SportRadarApiKey), "s37g6cgqfabegn5mu8snw293");
            set => AppSettings.AddOrUpdateValue(nameof(SportRadarApiKey), value);
        }

        public static IDictionary<string, string> LanguageMapper { get; } = new Dictionary<string, string>
        {
            {"en-US", "en" }
        };

        public static IDictionary<string, string> SportNameMapper { get; } = new Dictionary<string, string>
        {
            {"Soccer", "soccer" }
        };
    }
}