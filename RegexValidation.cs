using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailValidationProgram
{
    class RegexValidation
    {
        public void EmailValidation(string email)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$");

            if (regex.IsMatch(email))
            {
                Console.WriteLine("The Email is valid");
            }
            else
            {
                Console.WriteLine("The Email is not valid");
            }

        }

    }
}
