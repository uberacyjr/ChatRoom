using ChatRoom.Data.Model;
using ChatRoom.Shared.Constants;
using System;
using System.Collections.Generic;

namespace ChatRoom.Data
{
    public class StaticChatRoomData : IStaticChatRoomData
    {
        public List<Event> GetAllEvents()
        {
            int year = DateTime.Now.Year, month = DateTime.Now.Month, day = DateTime.Now.Day;
            int dayTomorrow = DateTime.Now.AddDays(1).Day;
            int dayYesterday = DateTime.Now.AddDays(-1).Day;

            var events = new List<Event>()
            {
                new Event(comment: null, "Bob", EventConstants.EnterTheRoom, new DateTime(year, month, day, 5, 00, 00)),
                new Event(comment: null, "Kate", EventConstants.EnterTheRoom, new DateTime(year, month, day, 5, 05, 00)),
                new Event(comment: "Hey, Kate - high five?", "Bob", EventConstants.Comment, new DateTime(year, month, day, 5, 15, 00)),
                new Event("Kate", EventConstants.HightFiveAnotherUser, new DateTime(year, month, day, 5, 17, 00), new EventInteraction(new User("Bob"))),
                new Event(comment: null, "Bob", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 5, 18, 00)),
                new Event(comment: "Oh, typical", "Kate", EventConstants.Comment, new DateTime(year, month, day, 5, 20, 00)),
                new Event(comment: null, "Kate", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 5, 21, 00)),
                new Event(comment: null, "Oliver", EventConstants.EnterTheRoom, new DateTime(year, month, day, 6, 00, 00)),
                new Event(comment: null, "George", EventConstants.EnterTheRoom, new DateTime(year, month, day, 6, 06, 00)),
                new Event(comment: null, "Amanda", EventConstants.EnterTheRoom, new DateTime(year, month, day, 6, 08, 00)),
                new Event(comment: "Hi All!", "Oliver", EventConstants.Comment, new DateTime(year, month, day, 6, 01, 00)),
                new Event(comment: "Hi Oliver!", "George", EventConstants.Comment, new DateTime(year, month, day, 6, 07, 00)),
                new Event(comment: "Hi!", "Amanda", EventConstants.Comment, new DateTime(year, month, day, 6, 09, 00)),
                new Event("Amanda", EventConstants.HightFiveAnotherUser, new DateTime(year, month, day, 6, 10, 00), new EventInteraction(new User("Oliver"))),
                new Event("George", EventConstants.HightFiveAnotherUser, new DateTime(year, month, day, 6, 11, 00), new EventInteraction(new User("Oliver"))),
                new Event(comment: null, "Amanda", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 6, 21, 00)),
                new Event(comment: null, "Oliver", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 6, 23, 00)),
                new Event(comment: null, "George", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 6, 25, 00)),
                new Event(comment: null, "Noah", EventConstants.EnterTheRoom, new DateTime(year, month, day, 7, 25, 00)),
                new Event(comment: "Wow, where is everybody?", "Noah", EventConstants.Comment, new DateTime(year, month, day, 7, 26, 00)),
                new Event(comment: null, "Noah", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 7, 27, 00)),
                new Event(comment: null, "Tes", EventConstants.EnterTheRoom, new DateTime(year, month, day, 18, 47, 00)),
                new Event(comment: "Good evening!", "Tes", EventConstants.Comment, new DateTime(year, month, day, 18, 49, 00)),
                new Event(comment: null, "Tes", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 18, 50, 00)),

                new Event(comment: null, "Jose", EventConstants.EnterTheRoom, new DateTime(year, month, dayTomorrow, 2, 21, 00)),
                new Event(comment: null, "Yara", EventConstants.EnterTheRoom, new DateTime(year, month, dayTomorrow, 3, 05, 00)),
                new Event(comment: null, "Jon", EventConstants.EnterTheRoom, new DateTime(year, month, dayTomorrow, 3, 09, 00)),
                new Event(comment: null, "Clara", EventConstants.EnterTheRoom, new DateTime(year, month, dayTomorrow, 4, 08, 00)),

                new Event(comment: null, "Maya", EventConstants.EnterTheRoom, new DateTime(year, month, dayYesterday, 4, 08, 00)),
                new Event(comment: "Hi all!", "Maya", EventConstants.Comment, new DateTime(year, month, dayYesterday, 4, 10, 00)),
                new Event(comment: "Good evening.", "Maya", EventConstants.Comment, new DateTime(year, month, dayYesterday, 4, 12, 00)),
                new Event(comment: "What is going on?.", "Maya", EventConstants.Comment, new DateTime(year, month, dayYesterday, 4, 13, 00)),
                new Event(comment: null, "Maya", EventConstants.LeaveTheRoom, new DateTime(year, month, dayYesterday, 4, 15, 00)),
            };

            return events;
        }
    }
}