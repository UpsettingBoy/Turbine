﻿using SteamAccountSwitch.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamAccountSwitch.Interfaces
{
    public interface ISteam
    {
        Task CloseSteamAsync();

        Task<IList<SteamAccountModel>> GetSteamAccountsAsync(bool forceDownload);
        Task LaunchSteamAsync(SteamAccountModel acc, bool offline);
    }
}