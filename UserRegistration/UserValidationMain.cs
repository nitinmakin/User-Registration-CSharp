namespace UserRegistration
{
    using System;
    using System.Text.RegularExpressions;
    public class UserValidationMain
    {
      
       
        public bool ValidateFirstName(string validation)
        {
            string FirstName = "^[A-Z]{1}([a-z]{2,15})*";
            return Regex.IsMatch(validation, FirstName);
        }
        public bool ValidateLastName(string validation)
        {
            string LastName = "^[A-Z]{1}([a-z]{2,15})*";
            return Regex.IsMatch(validation, LastName);
        }

    }
}
