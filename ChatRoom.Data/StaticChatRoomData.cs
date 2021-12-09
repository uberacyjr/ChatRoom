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
            var events = new List<Event>();

            int year = DateTime.Now.Year, month = DateTime.Now.Month, day = DateTime.Now.Day;
            var event1 = new Event(comment: null, "Bob", EventConstants.EnterTheRoom, new DateTime(year, month, day, 5, 00, 00));
            var event2 = new Event(comment: null, "Kate", EventConstants.EnterTheRoom, new DateTime(year, month, day, 5, 05, 00));
            var event3 = new Event(comment: "Hey, Kate - high five?", "Bob", EventConstants.Comment, new DateTime(year, month, day, 5, 15, 00));
            var event4 = new Event("Kate", EventConstants.HightFiveAnotherUser, new DateTime(year, month, day, 5, 17, 00), new EventInteraction(new User("Bob")));
            var event5 = new Event(comment: null, "Bob", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 5, 18, 00));
            var event6 = new Event(comment: "Oh, typical", "Kate", EventConstants.Comment, new DateTime(year, month, day, 5, 20, 00));
            var event7 = new Event(comment: null, "Kate", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 5, 21, 00));
            var event8 = new Event(comment: null, "Oliver", EventConstants.EnterTheRoom, new DateTime(year, month, day, 6, 00, 00));
            var event9 = new Event(comment: null, "George", EventConstants.EnterTheRoom, new DateTime(year, month, day, 6, 06, 00));
            var event10 = new Event(comment: null, "Amanda", EventConstants.EnterTheRoom, new DateTime(year, month, day, 6, 08, 00));
            var event11 = new Event(comment: "Hi All!", "Oliver", EventConstants.Comment, new DateTime(year, month, day, 6, 01, 00));
            var event12 = new Event(comment: "Hi Oliver!", "George", EventConstants.Comment, new DateTime(year, month, day, 6, 07, 00));
            var event13 = new Event(comment: "Hi!", "Amanda", EventConstants.Comment, new DateTime(year, month, day, 6, 09, 00));
            var event14 = new Event("Amanda", EventConstants.HightFiveAnotherUser, new DateTime(year, month, day, 6, 10, 00), new EventInteraction(new User("Oliver")));
            var event15 = new Event("George", EventConstants.HightFiveAnotherUser, new DateTime(year, month, day, 6, 11, 00), new EventInteraction(new User("Oliver")));
            var event16 = new Event(comment: null, "Amanda", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 6, 21, 00));
            var event17 = new Event(comment: null, "Oliver", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 6, 23, 00));
            var event18 = new Event(comment: null, "George", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 6, 25, 00));
            var event19 = new Event(comment: null, "Noah", EventConstants.EnterTheRoom, new DateTime(year, month, day, 7, 25, 00));
            var event20 = new Event(comment: "Wow, where is everybody?", "Noah", EventConstants.Comment, new DateTime(year, month, day, 7, 26, 00));
            var event21 = new Event(comment: null, "Noah", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 7, 27, 00));
            var event22 = new Event(comment: null, "Tes", EventConstants.EnterTheRoom, new DateTime(year, month, day, 18, 47, 00));
            var event23 = new Event(comment: "Good evening!", "Tes", EventConstants.Comment, new DateTime(year, month, day, 18, 49, 00));
            var event24 = new Event(comment: null, "Tes", EventConstants.LeaveTheRoom, new DateTime(year, month, day, 18, 50, 00));
            
            events.Add(event1);
            events.Add(event2);
            events.Add(event3);
            events.Add(event4);
            events.Add(event5);
            events.Add(event6);
            events.Add(event7);
            events.Add(event8);
            events.Add(event9);
            events.Add(event10);
            events.Add(event11);
            events.Add(event12);
            events.Add(event13);
            events.Add(event14);
            events.Add(event15);
            events.Add(event16);
            events.Add(event17);
            events.Add(event18);
            events.Add(event19);
            events.Add(event20);
            events.Add(event21);
            events.Add(event22);
            events.Add(event23);
            events.Add(event24);

            return events;
        }
    }
}