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
        public void GivenCorrectFirstName_ShouldPassTest()
        {
            UserValidationMain userValidation = new UserValidationMain();
            bool result = userValidation.ValidateFirstName("Nitin");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenCorrectLastName_ShouldPassTest()
        {
            UserValidationMain userValidation = new UserValidationMain();
            bool result = userValidation.ValidateLastName("Makin");
            Assert.IsTrue(result);
        }
    }
}