using ChatRoom.Shared.Constants;
using System.Collections.Generic;

namespace ChatRoom.Shared.Services
{
    public static class ConstantsHelperService
    {
        public static List<string> GetEventTypeConstants()
        {
            return new List<string>()
            {
                EventConstants.EnterTheRoom,
                EventConstants.LeaveTheRoom,
                EventConstants.Comment,
                EventConstants.HightFiveAnotherUser
            };
        }
    }
}