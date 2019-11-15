﻿using System.Net.Http;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class HttpBytesReader : IHttpBytesReader
    {
        public byte[] ReadBytes(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(url).Result;
            byte[] bytes = response.Content.ReadAsByteArrayAsync().Result;

            return bytes;
        }
    }
}