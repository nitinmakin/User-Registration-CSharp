namespace UserRegistration
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Main Class
    /// </summary>
    public class UserValidationMain
    {
        /// <summary>
        /// Method to validate first name
        /// </summary>
        /// <param name="validation"></param>
        /// <returns></returns>
        public bool ValidateFirstName(string validation)
        {
            string firstName = "^[A-Z]{1}([a-z]{2,15})*";
            return Regex.IsMatch(validation, firstName);
        }

        /// <summary>
        /// Method to validate last name
        /// </summary>
        /// <param name="validation"></param>
        /// <returns></returns>
        public bool ValidateLastName(string validation)
        {
            string lastName = "^[A-Z]{1}([a-z]{2,15})*";
            return Regex.IsMatch(validation, lastName);
        }

        /// <summary>
        /// Method to validate email
        /// </summary>
        /// <param name="validation"></param>
        /// <returns></returns>
        public bool ValidateEmail(string validate)
        {
            string email = "^[a-zA-Z]+[a-zA-Z0-9]*[._+-]?[a-zA-Z0-9]*@[A-Za-z0-9]+([.][a-zA-Z]{2,})$";
            return Regex.IsMatch(validate, email);
        }

        /// <summary>
        /// Method to validate phone no
        /// </summary>
        /// <param name="validation"></param>
        /// <returns></returns>
        public bool ValidatePhoneNo(string validate)
        {
            string phoneNo = "^([0]|\\+91)?[6789]\\d{9}$"; 
            return Regex.IsMatch(validate, phoneNo );
        }
    }
}
