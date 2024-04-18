using UserAccountBusinessServices;
using System;

namespace UserAccountUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your Username: ");
            string Username = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string Password = Console.ReadLine();

            UserAccountService userAccountService = new UserAccountService();
            bool result = userAccountService.VerifyUser(Username);

            if (result)
            {
                Console.WriteLine("Succesful Login");

            }
            else
            {
                Console.WriteLine("Error");

            }
        }
    }
}
