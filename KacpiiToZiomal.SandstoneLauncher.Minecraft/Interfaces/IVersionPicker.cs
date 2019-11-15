﻿using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    /// <summary>
    ///     finding every game versions. ENDPOINT = https://launchermeta.mojang.com/mc/game/version_manifest.json
    /// </summary>
    [Obsolete("use IManifestGetter, ManifestGetter")]
    public interface IVersionPicker
    {
        VersionManifest PickAll();
    }
}