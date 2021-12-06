using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //display message and read user email adress
            Console.WriteLine("Please enter your email: ");
            string inputEmail = Console.ReadLine();

            //verify if email adress is valid
            if (inputEmail.Contains('@'))
            {
                //split the email adress in 2 parts: username & domain
                var parts = inputEmail.Split('@');
                string username = parts[0];
                string domain = parts[1];
                int usernameLength = username.Length;

                //create an empty string
                string censoredUsername = string.Empty;
                for (char i = (char)0; i < usernameLength; i++)
                {
                    censoredUsername = censoredUsername + '*';
                }

                // concate the results to output censored email
                string newEmail = censoredUsername + '@' + domain;
                Console.WriteLine(newEmail);
            }

            //output message in case of an invalid email
            else
            {
                Console.WriteLine("The string you entered is not a valid email");
            }
            
        }
    }
}
