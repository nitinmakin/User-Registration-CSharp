namespace NUnitTestUserRegistration
{
    using NUnit.Framework;
    using UserRegistration;

    /// <summary>
    /// test class
    /// </summary>
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
        [Test]
        public void GivenCorrectEmail_ShouldPassTest()
        {
            UserValidationMain userValidation = new UserValidationMain();
            bool result = userValidation.ValidateEmail("nitinmakin124@gmail.com");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenCorrectPhoneNo_ShouldPassTest()
        {
            UserValidationMain userValidation = new UserValidationMain();
            bool result = userValidation.ValidatePhoneNo("07829376277");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenCorrectPAsswordRule1Min8Char_ShouldPassTest()
        {
            UserValidationMain userValidation = new UserValidationMain();
            bool result = userValidation.ValidatePassword("nitinmakin");
            Assert.IsTrue(result);
        }
    }
}