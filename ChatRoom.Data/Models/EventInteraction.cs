namespace ChatRoom.Data.Model
{
    public class EventInteraction
    {
        public EventInteraction(User user)
        {
            User = user;
        }

        public int Id { get; set; }
        public User User { get; set; }
    }
}                                                                                                         