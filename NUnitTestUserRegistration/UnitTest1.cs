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
            bool result = userValidation.ValidatePasswordRule1("nitinmakin");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenCorrectPAsswordRule2Alteast1Uppercase_ShouldPassTest()
        {
            UserValidationMain userValidation = new UserValidationMain();
            bool result = userValidation.ValidatePasswordRule2("NitinMakin");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenCorrectPAsswordRule3Alteast1NumaricNumber_ShouldPassTest()
        {
            UserValidationMain userValidation = new UserValidationMain();
            bool result = userValidation.ValidatePasswordRule3("NitinMakin124");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenCorrectPAsswordRule4MustHaveOnly1SpecialChar_ShouldPassTest()
        {
            UserValidationMain userValidation = new UserValidationMain();
            Assert.IsTrue(userValidation.ValidatePasswordRule4("NitinMakin124@"));
        }
        [Test]
        public void TestCaseForValidatingAllTheEmails()
        {
            UserValidationMain userValidation = new UserValidationMain();
            Assert.IsTrue(userValidation.ValidateEmail("nitinmakin124@gmail.com"));
            Assert.IsTrue(userValidation.ValidateEmail("abc.ced@gmail.com"));
            Assert.IsTrue(userValidation.ValidateEmail("abc@gmail.com"));
            Assert.IsTrue(userValidation.ValidateEmail("abc@gmail.in"));
            Assert.IsTrue(userValidation.ValidateEmail("abc.cedfac@gmail.com"));
            Assert.IsTrue(userValidation.ValidateEmail("n12345667@gmail.com"));
            Assert.IsTrue(userValidation.ValidateEmail("abc+ced@gmail.com"));
            Assert.IsTrue(userValidation.ValidateEmail("abc-ced@gmail.com"));
            Assert.IsTrue(userValidation.ValidateEmail("abc_ced@gmail.com"));
            Assert.IsTrue(userValidation.ValidateEmail("abcced@gmail.com"));
            Assert.IsTrue(userValidation.ValidateEmail("a12dd77@gmail.in"));

        }
    }

}
