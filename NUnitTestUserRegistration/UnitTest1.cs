using NUnit.Framework;
using UserRegistration;

namespace NUnitTestUserRegistration
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void GivenCorrectName_ShouldPassTest()
        {
            UserValidationMain userValidation = new UserValidationMain();
           bool result = userValidation.ValidateGivenInput("Nitin");
            Assert.IsTrue(result);
        }
    }
}