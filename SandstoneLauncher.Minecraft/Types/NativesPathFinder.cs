﻿using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class NativesPathFinder : INativesPathFinder
    {
        public IPathConverter Converter;
        public IMinecraftDirectory MinecraftDirectory;

        public NativesPathFinder(IMinecraftDirectory minecraftDirectory, IPathConverter converter)
        {
            MinecraftDirectory = minecraftDirectory;
            Converter = converter;
        }

        public string GetNativesDirectory(string versionid)
        {
            return MinecraftDirectory.GetVersions() + versionid + "\\" + versionid + "-natives\\";
        }

        public string GetPath(DownloadArtifact art)
        {
            string path = Converter.Convert(art.Path);
            return MinecraftDirectory.GetVersions() + "natives\\" + path;
        }
    }
}