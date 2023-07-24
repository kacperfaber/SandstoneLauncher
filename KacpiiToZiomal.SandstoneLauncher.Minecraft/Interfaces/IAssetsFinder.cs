﻿using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsFinder
    {
        Assets GetAssets(string url, FullVersion version);
    }
}