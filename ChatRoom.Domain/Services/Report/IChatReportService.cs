using ChatRoom.Data.Model;
using ChatRoom.Domain.Model;
using System.Collections.Generic;

namespace ChatRoom.Domain.Services.Report
{
    public interface IChatReportService
    {
        IEnumerable<ChatReportDto> GetChatReportByHourlyAggreationLevel(IEnumerable<Event> events);
        IEnumerable<ChatReportDto> GetChatReportByMinuteAggreationLevel(IEnumerable<Event> events);
    }
}