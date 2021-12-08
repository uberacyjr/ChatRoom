namespace ChatRoom.Data.Model
{
    public class EventType
    {
        public EventType()
        {
        }
        public EventType(string description)
        {
            Description = description;
        }
        public int Id { get; set; }
        public string Description { get; set; }
    }
}