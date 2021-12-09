using ChatRoom.Shared.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatRoom.Test.ConstantTests
{
    [TestClass]
    public class EventConstantsTests
    {
        [TestMethod]
        public void CheckEventConstantsValue()
        {
            Assert.IsTrue(EventConstants.EnterTheRoom == "enter(s) the room");
            Assert.IsTrue(EventConstants.LeaveTheRoom == "leave(s) the room");
            Assert.IsTrue(EventConstants.Comment == "comments");
            Assert.IsTrue(EventConstants.HightFiveAnotherUser == "high five");
            Assert.IsTrue(EventConstants.People == "people");
            Assert.IsTrue(EventConstants.Person == "person");
        }
    }
}