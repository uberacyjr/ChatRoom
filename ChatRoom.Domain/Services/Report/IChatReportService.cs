using ChatRoom.Domain.Models;
using System.Collections.Generic;

namespace ChatRoom.Domain.Services.Report
{
    public interface IChatReportService
    {
        IEnumerable<ChatReportDto> GetChatReportByHourlyAggreationLevel();
        IEnumerable<ChatReportDto> GetChatReportByMinuteAggreationLevel();
    }
}