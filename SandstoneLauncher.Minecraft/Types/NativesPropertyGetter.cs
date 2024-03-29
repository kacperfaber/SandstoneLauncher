﻿using System;
using System.Linq;
using System.Reflection;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class NativesPropertyGetter : INativesPropertyGetter
    {
        public string GetValue(Natives n, string name)
        {
            Type t = n.GetType();
            PropertyInfo[] props = t.GetProperties();
            PropertyInfo p = props.Where(x => x.Name.ToLower() == name.ToLower()).First();

            return (string)p.GetValue(n);
        }
    }
}