﻿using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IArtifactFinder
    {
        DownloadArtifact GetDownloadArtifact(Library library, OS system);
    }
}