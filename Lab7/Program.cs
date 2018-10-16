using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name.");
            string name = Console.ReadLine();
            bool isValidName = IsNameValid(name);

            if (isValidName)
            {
                Console.WriteLine("{0} is a valid name", name);
            }
            else
            {
                Console.WriteLine("{0} is not a valid name", name);
            }

            Console.WriteLine("Please enter a valid email");
            string email = Console.ReadLine();
            bool isValidEmail = IsEmailValid(email);

            if (isValidEmail)
            {
                Console.WriteLine("{0} is a valid email", email);
            }
            else
            {
                Console.WriteLine("{0} is not a valid email", email);
            }

            Console.WriteLine("Please enter a valid phone number");
            string number = Console.ReadLine();
            bool isValidNumber = IsNumberValid(number);

            if (isValidNumber)
            {
                Console.WriteLine("{0} is a valid phone number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a phone number", number);
            }

            Console.WriteLine("Please enter a valid date of this format dd/mm/yyyy");
            string date = Console.ReadLine();
            bool isValidDate = IsDateValid(date);

            if (isValidDate)
            {
                Console.WriteLine("{0} is a valid date", date);
            }
            else
            {
                Console.WriteLine("{0} is not a valid date", date);
            }
           

            Console.WriteLine("Please enter valid html");
            string html = Console.ReadLine();
            bool isValidHTML = IsHTMLValid(html);

            if (isValidHTML)
            {
                Console.WriteLine("{0} is valid HTML", html);
            }
            else
            {
                Console.WriteLine("{0} is not valid HTML", html);
            }
            Console.ReadKey();
        }


        private static bool IsNameValid(string name)
        {
            return Regex.IsMatch(name, @"^[A-Z]+[A-z]{1,30}$");
        }
        private static bool IsEmailValid(string email)
        {
            return Regex.IsMatch(email, @"^[A-Za-z0-9_]{5,30}@[A-Za-z0-9_]{5,10}.[A-Za-z0-9_]{2,3}$");
        }
        private static bool IsNumberValid(string number)
        {
            return Regex.IsMatch(number, @"^\d\d\d-\d\d\d-\d\d\d\d$");
        }
        private static bool IsDateValid(string date)
        {
           return Regex.IsMatch(date, @"^\d\d[/]\d\d[/]\d\d\d\d$");
        }
        private static bool IsHTMLValid(string html)
        {
            return Regex.IsMatch(html, @"^[<][a-z0-9_][>]|[</][a-z0-9_][>]$");
        }
    }
}
