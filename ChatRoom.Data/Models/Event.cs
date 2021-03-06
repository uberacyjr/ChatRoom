using System;

namespace ChatRoom.Data.Model
{
    public class Event
    {
        public Event()
        {
            EventType = new();
            User = new();
        }

        public Event(string comment, string userName, string eventDescripton, DateTime insertedDate)
        {
            Comment = comment;
            InsertedDate = insertedDate;
            User = new User(userName);
            EventType = new EventType(eventDescripton);
        }

        public Event(string userName, string eventDescripton, 
                     DateTime insertedDate, EventInteraction eventInteraction)
        {
            InsertedDate = insertedDate;
            User = new User(userName);
            EventType = new EventType(eventDescripton);
            EventInteraction = eventInteraction;
        }

        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime InsertedDate { get; set; }
        public EventType EventType { get; set; }
        public User User { get; set; }
        public EventInteraction EventInteraction { get; set; }
    }
}