using ChatRoom.Data.Model;
using System.Collections.Generic;

namespace ChatRoom.Data
{
    public interface IStaticChatRoomData
    {
        List<Event> GetAllEvents();
    }
}