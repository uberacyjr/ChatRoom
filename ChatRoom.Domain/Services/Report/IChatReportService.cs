using ChatRoom.Domain.Models;
using System;
using System.Collections.Generic;

namespace ChatRoom.Domain.Services.Report
{
    public interface IChatReportService
    {
        IEnumerable<ChatReportDto> GetChatReportByHourlyAggregationLevel(DateTime dateFilter);
        IEnumerable<ChatReportDto> GetChatReportByMinuteAggregationLevel(DateTime dateFilter);
    }
}