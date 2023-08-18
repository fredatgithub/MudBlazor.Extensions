// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading.Tasks;
using MudBlazor.Extensions.Explorer.Services;
using NUnit.Framework;
using Shouldly;

namespace MudBlazor.Extensions.Tests
{
    [TestFixture]
    public class NugetServiceTests
    {
        [Test]
        public async Task TestGetLatestVersion()
        {
            var service = new NugetService();
            var version = await NugetService.GetLatestVersion("https://www.nuget.org/packages/MudBlazor/");
            Console.WriteLine("Version: " + version);
            version.ShouldMatch(@"(\d+\.)+", version);
        }
    }
}
