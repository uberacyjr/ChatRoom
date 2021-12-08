namespace ChatRoom.Data.Model
{
    public class EventInteraction
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public User User { get; set; }
    }
}                                                                                                         