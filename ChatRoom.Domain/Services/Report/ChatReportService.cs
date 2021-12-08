using ChatRoom.Data.Model;
using ChatRoom.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace ChatRoom.Domain.Services.Report
{
    public class ChatReportService : IChatReportService
    {
        public IEnumerable<ChatReportDto> GetChatReportByMinuteAggreationLevel(IEnumerable<Event> events)
        {
            return events.OrderBy(o => o.InsertedDate)
                         .Select(s => new ChatReportDto
                         {
                             AggregationLevel = s.InsertedDate.ToString("HH:mm"),
                             Description = $"{s.User.Name} {s.EventType.Description}"
                         });
        }

        public IEnumerable<ChatReportDto> GetChatReportByHourlyAggreationLevel(IEnumerable<Event> events)
        {
            return events.OrderBy(o => o.InsertedDate)
                         .GroupBy(g => new { g.InsertedDate.TimeOfDay.Hours, g.EventType })
                         .Select(s => new { Total = s.Count(), s.FirstOrDefault().EventType, s.Key.Hours })
                         .GroupBy(g => new { g.Hours })
                         .Select(s => new ChatReportDto
                         {
                             AggregationLevel = s.Key.Hours.ToString(),
                             Description = s.FirstOrDefault().EventType.Description,
                             Total = s.FirstOrDefault().Total
                         });
        }
    }
}