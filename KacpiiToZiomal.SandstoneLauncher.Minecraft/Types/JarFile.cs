﻿using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class JarFile : IJarFile
    {
        private string File;

        public JarFile(string jar)
        {
            File = jar;
        }

        public string[] GetDirectories()
        {
            throw new NotImplementedException();
        }

        public string[] GetFiles()
        {
            throw new NotImplementedException();
        }
    }
}