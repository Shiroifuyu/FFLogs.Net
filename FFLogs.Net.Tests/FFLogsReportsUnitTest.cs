﻿using System.Linq;
using System.Threading.Tasks;
using FFLogs.Net.Models.Helpers;
using FFLogs.Net.Models.Report;
using FFLogs.Net.Models.Reports;
using NUnit.Framework;

namespace FFLogs.Net.Tests
{
    public class FFLogsReportsUnitTest : BaseUnitTest
    {
        [Test]
        public async Task GetGuildReportsAsync()
        {
            Reports[] result = await FFLogsClient.GetGuildReportsAsync("EXPLOSION MAGIC", Europe.Chaos.Cerberus);
            
            Assert.AreEqual("Eden's Verse", result.FirstOrDefault(x =>x.Id == "HVxTkRN9yhvXZ1rd")?.Title);
            Assert.AreEqual("kriers", result.FirstOrDefault(x =>x.Id == "HVxTkRN9yhvXZ1rd")?.Owner);
        }
        
        [Test]
        public async Task GetCharacterReportsAsync()
        {
            var result = await FFLogsClient.GetUserReportsAsync("aghanim");
            
            Assert.AreEqual("Dungeons (Endgame)", result.FirstOrDefault(x =>x.Zone == 27)?.Title);
            Assert.AreEqual("aghanim", result.FirstOrDefault()?.Owner);
        }
        [Test]
        public async Task GetReportsTablesAsync()
        {
            var result = await FFLogsClient.GetReportsTables("summary", "a1mXWRfqYhzxPdCb",new ReportsTablesOptions(){ start = 1051410 ,end = 1637165 });
        }
        [Test]
        public async Task GetReportsFightsAsync()
        {
            var result = await FFLogsClient.GetReportsFights("a1mXWRfqYhzxPdCb");
        }
    }
}