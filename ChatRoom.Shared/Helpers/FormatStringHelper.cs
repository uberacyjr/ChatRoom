using ChatRoom.Shared.Constants;

namespace ChatRoom.Shared.Helpers
{
    public static class FormatStringHelper
    {
        public static string AddQuoteMark(string text) => !string.IsNullOrEmpty(text) ? $"\"{text}\"" : string.Empty;
        public static string GetPersonOrPeopleDescription(int totalPeople) => totalPeople > 1 ? EventConstants.People : EventConstants.Person;
    }
}