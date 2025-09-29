using System.Net.Cache;

namespace Practice0929
{
    internal class Program
    {




        static void Main(string[] args)
        {
            int userAge;
            bool validLicense;

            Console.WriteLine("Whats your age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            userAge = Age;

            Console.WriteLine("Do you have a valid drivers license? [Y/N]");

            string License = Console.ReadLine().ToLower();

            if(License == "y")
            {
                validLicense = true;
            }
            else
            {
                validLicense = false;
            }

            User user = new User(userAge, validLicense);
            user.IsUserAllowedToDrive();




           
           


        }
    }
}
