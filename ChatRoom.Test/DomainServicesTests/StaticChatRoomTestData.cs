using ChatRoom.Data;
using ChatRoom.Data.Model;
using ChatRoom.Shared.Constants;
using System;
using System.Collections.Generic;

namespace ChatRoom.Test.DomainServicesTests
{
    public class StaticChatRoomTestData : IStaticChatRoomData
    {
        public List<Event> GetAllEvents()
        {
            var events = new List<Event>();
            int year = DateTime.Now.Year, month = DateTime.Now.Month, day = DateTime.Now.Day;
            var event1 = new Event(comment: null, "Bob", EventConstants.EnterTheRoom, new DateTime(year, month, day, 5, 00, 00));
            var event2 = new Event(comment: null, "Kate", EventConstants.EnterTheRoom, new DateTime(year, month, day, 5, 05, 00));
            var event3 = new Event(comment: "Hey, Kate - high five?", "Bob", EventConstants.Comment, new DateTime(year, month, day, 5, 15, 00));
            var event4 = new Event("Kate", EventConstants.HightFiveAnotherUser, new DateTime(year, month, day, 5, 17, 00), new EventInteraction(new User("Bob")));
            var event5 = new Event(comment: null, "Bob", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 5, 18, 00));
            var event6 = new Event(comment: "Oh, typical", "Kate", EventConstants.Comment, new DateTime(year, month, day, 5, 20, 00));
            var event7 = new Event(comment: null, "Kate", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 5, 21, 00));
            events.Add(event1);
            events.Add(event2);
            events.Add(event3);
            events.Add(event4);
            events.Add(event5);
            events.Add(event6);
            events.Add(event7);
            return events;
        }
    }
}