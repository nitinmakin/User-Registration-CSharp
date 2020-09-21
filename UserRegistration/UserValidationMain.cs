namespace UserRegistration
{
    using System.Text.RegularExpressions;
    public class UserValidationMain
    {
        string FirstName = "^[A-Z]{1}([a-z]{2,15})*";
        public bool ValidateGivenInput(string validation)
        {
            return Regex.IsMatch(validation, FirstName);
        }
    }
}
