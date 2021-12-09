using ChatRoom.Shared.Constants;
using ChatRoom.Shared.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatRoom.Test.HelperTests
{
    [TestClass]
    public class FormatStringHelperTests
    {
        [TestMethod]
        public void WhenAddQuoteMarkReturnQuoteMark()
        {
            Assert.IsTrue(FormatStringHelper.AddQuoteMark("Some random test").Contains("\""));
        }

        [TestMethod]
        public void WhenPassTotalPeopleQuantityGreaterThanOneReturnPeople ()
        {
            Assert.IsTrue(FormatStringHelper.GetPersonOrPeopleDescription(2) == EventConstants.People);
        }

        [TestMethod]
        public void WhenPassTotalPeopleQuantityEqualToOneReturnPerson()
        {
            Assert.IsTrue(FormatStringHelper.GetPersonOrPeopleDescription(1) == EventConstants.Person);
        }
    }
}
