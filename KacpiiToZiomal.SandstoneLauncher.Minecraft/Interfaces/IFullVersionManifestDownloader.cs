﻿using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IFullVersionManifestDownloader
    {
        void Download(GameVersion version);
    }
}