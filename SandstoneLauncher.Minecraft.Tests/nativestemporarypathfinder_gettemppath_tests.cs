﻿#region

using System;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class nativestemporarypathfinder_gettemppath_tests
    {
        private string execute(string path)
        {
            NativesTemporaryPathFinder f =
                new NativesTemporaryPathFinder(new FileNameExtractor(new PathConverter()), new mc());
            return f.GetTemporaryPath(new DownloadArtifact { Path = path });
        }

        [Test]
        public void dont_throws()
        {
            Assert.DoesNotThrow(() => execute("com\\google\\google.jar"));
        }

        [Test]
        public void returns_excepted_results()
        {
            Assert.AreEqual("versions\\natives-jars\\k.jar", execute("com\\google\\k.jar"));
        }

        private class mc : IMinecraftDirectory
        {
            public string GetAssets()
            {
                throw new NotImplementedException();
            }

            public string GetLibraries()
            {
                throw new NotImplementedException();
            }

            public string GetMinecraft()
            {
                return "versions\\";
            }

            public string GetVersions()
            {
                throw new NotImplementedException();
            }
        }
    }
}