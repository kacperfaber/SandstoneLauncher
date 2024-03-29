﻿using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    
public class DownloadLibrary
    {
        [JsonProperty("artifact")]
        public DownloadArtifact Artifact { get; set; }

        [JsonProperty("classifiers")]
        public Classifiers Classifiers { get; set; }
    }
}