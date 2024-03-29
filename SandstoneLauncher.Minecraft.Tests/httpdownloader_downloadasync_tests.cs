﻿using System;
using System.IO;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

namespace SandstoneLauncher.Minecraft.Tests
{
public class httpdownloader_downloadasync_tests
    {
        private string Filename = "tests\\" + Guid.NewGuid() + ".html";
        private string Url = "https://file-examples.com/wp-content/uploads/2017/02/index.html";

        [SetUp]
        public void setup()
        {
            HttpDownloader downloader = HttpDownloader.Default;
            downloader.DownloadAsync(Url, Filename);
        }

        [TearDown]
        public void teardown()
        {
            if (File.Exists(Filename)) File.Delete(Filename);
        }

        [Test]
        public void file_is_exists()
        {
            Assert.IsTrue(File.Exists(Filename));
        }

        [Test]
        public void file_not_empty()
        {
            string text = File.ReadAllText(Filename);
            Assert.IsNotEmpty(text);
        }

        [Test]
        public void returns_string_starts_with_html_clause()
        {
            Assert.IsTrue(File.ReadAllText(Filename).StartsWith("<html>"));
        }
    }
}