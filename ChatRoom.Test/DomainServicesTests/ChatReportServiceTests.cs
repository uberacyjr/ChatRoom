using ChatRoom.Domain.Services.Report;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ChatRoom.Test.DomainServicesTests
{
    [TestClass]
    public class ChatReportServiceTests
    {
        protected ChatReportService ChatReportServiceUnderTest { get;}
        public ChatReportServiceTests()
        {
            ChatReportServiceUnderTest = new ChatReportService(new StaticChatRoomTestData());
        }

        [DataRow("enter(s) the room")]
        [DataRow("comments")]
        [DataRow("high five")]
        [DataRow("leave(s)")]
        [DataTestMethod]
        public void WhenGetHourlyReportReturnEventTypes(string assertMessage)
        {
            var resultByHour = ChatReportServiceUnderTest.GetChatReportByHourlyAggregationLevel(DateTime.Now);
            Assert.IsTrue(resultByHour.SelectMany(s => s.Descriptions).Any(a => a.Contains(assertMessage)));
        }

        [TestMethod]
        public void WhenGetHourlyReportReturnNullDescription()
        {
            var resultByHour = ChatReportServiceUnderTest.GetChatReportByHourlyAggregationLevel(DateTime.Now);
            foreach (var result in resultByHour)
            {
                Assert.IsNull(result.Description);
            }
        }

        [TestMethod]
        public void WhenGetHourlyReportReturnAggregationLevel()
        {
            var resultByHour = ChatReportServiceUnderTest.GetChatReportByHourlyAggregationLevel(DateTime.Now);
            foreach (var result in resultByHour)
            {
                Assert.IsNotNull(result.AggregationLevel);
            }
        }

        [TestMethod]
        public void WhenGetHourlyReportReturnDescriptions()
        {
            var resultByHour = ChatReportServiceUnderTest.GetChatReportByHourlyAggregationLevel(DateTime.Now);
            foreach (var result in resultByHour)
            {
                Assert.IsNotNull(result.Descriptions);
            }
        }

        [DataRow("enter(s) the room")]
        [DataRow("comments")]
        [DataRow("high five")]
        [DataRow("leave(s)")]
        [DataTestMethod]
        public void WhenGetMinuteReportReturneEventTypes(string assertMessage)
        {
            var resultByMinute = ChatReportServiceUnderTest.GetChatReportByMinuteAggregationLevel(DateTime.Now);
            Assert.IsTrue(resultByMinute.Any(a => a.Description.Contains(assertMessage)));
        }

        [TestMethod]
        public void WhenGetMinuteReportReturnDescription()
        {
            var resultByMinute = ChatReportServiceUnderTest.GetChatReportByMinuteAggregationLevel(DateTime.Now);
            foreach (var result in resultByMinute)
            {
                Assert.IsNotNull(result.Description);
            }
        }

        [TestMethod]
        public void WhenGetMinuteReportReturnAggregationLevel()
        {
            var resultByHour = ChatReportServiceUnderTest.GetChatReportByMinuteAggregationLevel(DateTime.Now);
            foreach (var result in resultByHour)
            {
                Assert.IsNotNull(result.AggregationLevel);
            }
        }

        [TestMethod]
        public void WhenGetMinuteReportReturnNullDescriptions()
        {
            var resultByMinute = ChatReportServiceUnderTest.GetChatReportByMinuteAggregationLevel(DateTime.Now);
            foreach (var result in resultByMinute)
            {
                Assert.IsNull(result.Descriptions);
            }
        }
    }
}