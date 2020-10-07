using System;
using System.Text.RegularExpressions;

namespace EmailValidationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Email :");
            string email = Console.ReadLine();
            RegexValidation reg = new RegexValidation();
            reg.EmailValidation(email);
        }
    }
}
