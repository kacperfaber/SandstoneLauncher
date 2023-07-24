﻿using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class LibraryPathBuilder : ILibraryPathBuilder
    {
        public IPathConverter Converter;
        public IMinecraftDirectory MinecraftDir;

        public LibraryPathBuilder(IMinecraftDirectory minecraftDir, IPathConverter converter)
        {
            MinecraftDir = minecraftDir;
            Converter = converter;
        }

        public string Build(Library lib)
        {
            return MinecraftDir.GetLibraries() + Converter.Convert(lib.Download.Artifact.Path);
        }
    }
}