﻿using ChatRoom.Data;
using ChatRoom.Domain.Models;
using ChatRoom.Shared.Services;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChatRoom.Domain.Services.Report
{
    public class ChatReportService : IChatReportService
    {
        public IStaticChatRoomData StaticChatRoomData { get; set; }
        public ChatReportService(IStaticChatRoomData staticChatRoomData)
        {
            StaticChatRoomData = staticChatRoomData;
        }

        public IEnumerable<ChatReportDto> GetChatReportByMinuteAggreationLevel()
        {
            return StaticChatRoomData.GetAllEvents()
                                     .OrderBy(o => o.InsertedDate)
                                     .Select(s => new ChatReportDto
                                     {
                                         AggregationLevel = s.InsertedDate.ToString("HH:mm tt"),
                                         Description = $"{s.User.Name} {s.EventType.Description} " +
                                         $"{FormatStringHelperService.AddQuoteMark(s.Comment)} " +
                                         $"{s.EventInteraction?.User?.Name}"
                                     });
        }

        public IEnumerable<ChatReportDto> GetChatReportByHourlyAggreationLevel()
        {
            var hourlyReportResult = new List<ChatReportDto>();

            var aggregatedEvents = StaticChatRoomData.GetAllEvents()
                                                     .OrderBy(o => o.InsertedDate)
                                                     .GroupBy(g => new
                                                     {
                                                         g.InsertedDate.TimeOfDay.Hours,
                                                         TimeOfTheDay = g.InsertedDate.ToString("tt", CultureInfo.InvariantCulture),
                                                         EventType = g.EventType.Description
                                                     })
                                                     .Select(s => new
                                                     {
                                                         Total = s.Count(),
                                                         s.FirstOrDefault().EventType,
                                                         s.Key.Hours,
                                                         s.Key.TimeOfTheDay,
                                                         Users = s.Where(e => e.EventInteraction != null)
                                                                  .GroupBy(e => e.User.Name)
                                                                  .Select(g => new { User = g.Key, InteractionQtd = g.Select(c => c.EventInteraction).Count() })
                                                     }).GroupBy(g => new { g.Hours });

            foreach (var aggregatedEvent in aggregatedEvents)
            {
                var result = new ChatReportDto
                {
                    AggregationLevel = aggregatedEvent.Key.Hours + aggregatedEvent.FirstOrDefault().TimeOfTheDay + ":",
                    Descriptions = new List<string>()
                };

                foreach (var groupedEventType in aggregatedEvent.GroupBy(g => g.EventType))
                {
                    var totalEvents = groupedEventType.FirstOrDefault().Total;
                    var eventDescription = groupedEventType.Key;

                    if (!groupedEventType.SelectMany(s => s.Users).Any())
                    {
                        result.Descriptions.Add($"{totalEvents} " +
                            $"{FormatStringHelperService.GetPersonOrPeopleDescription(totalEvents)} " +
                            $"{eventDescription.Description}");
                    }

                    var totalUserSentInteraction = groupedEventType.SelectMany(s => s.Users).Count();
                    var totalUserReceivedInteraction = groupedEventType.SelectMany(s => s.Users)
                                                                       .Select(s => s.InteractionQtd)
                                                                       .Sum();
                    if (totalUserSentInteraction > 0)
                    {
                        result.Descriptions.Add($"{totalUserSentInteraction} " +
                            $"{FormatStringHelperService.GetPersonOrPeopleDescription(totalUserSentInteraction)} " +
                            $"{groupedEventType.FirstOrDefault().EventType.Description} {totalUserReceivedInteraction} " +
                            $"other {FormatStringHelperService.GetPersonOrPeopleDescription(totalUserReceivedInteraction)}");
                    }
                }

                hourlyReportResult.Add(result);
            }

            return hourlyReportResult;
        }
    }
}