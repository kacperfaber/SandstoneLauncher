﻿using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class DirectoryCreator : IDirectoryCreator
    {
        public IFileNameRemover Remover;

        public DirectoryCreator(IFileNameRemover remover)
        {
            Remover = remover;
        }

        public static DirectoryCreator Default => new DirectoryCreator(new FileNameRemover());

        public void Create(string path)
        {
            string dirpath = Remover.Remove(path);
            Directory.CreateDirectory(dirpath);
        }
    }
}