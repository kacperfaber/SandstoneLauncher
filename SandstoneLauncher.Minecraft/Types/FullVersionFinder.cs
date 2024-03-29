﻿using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class FullVersionFinder : IFullVersionFinder
    {
        public IHttpClient Client;
        public IJsonParser<FullVersion> Parser;

        public FullVersionFinder(IHttpClient client, IJsonParser<FullVersion> parser)
        {
            Client = client;
            Parser = parser;
        }

        public FullVersion Find(string url)
        {
            string json = Client.GetContent(url);
            return Parser.Parse(json);
        }
    }
}