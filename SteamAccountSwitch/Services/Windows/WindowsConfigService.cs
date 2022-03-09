﻿using SteamAccountSwitch.Interfaces;

using System;
using System.Threading.Tasks;

using Windows.Storage;

namespace SteamAccountSwitch.Services.Windows
{
    public class WindowsConfigService : IConfig
    {
        public int Count => settingsContainer.Values.Count;

        private ApplicationDataContainer settingsContainer;

        public WindowsConfigService()
        {
            settingsContainer = ApplicationData.Current.LocalSettings;
        }

        public T GetConfig<T>(string key)
        {
            var value = settingsContainer.Values[key];
            return (T)value;
        }

        public void SetConfig(string key, object? value)
        {
            settingsContainer.Values[key] = value;
        }

        public async Task ClearConfigAsync()
        {
            await ApplicationData.Current.ClearAsync();
        }

    }
}