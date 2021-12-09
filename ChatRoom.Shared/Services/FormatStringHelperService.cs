namespace ChatRoom.Shared.Services
{
    public static class FormatStringHelperService
    {
        public static string AddQuoteMark(string text) => !string.IsNullOrEmpty(text) ? $"\"{text}\"" : string.Empty;
        public static string GetPersonOrPeopleDescription(int totalPeople) => totalPeople > 1 ? "people" : "person";
    }
}