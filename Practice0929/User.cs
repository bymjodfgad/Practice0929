using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice0929
{
    public class User
    {
        public int userAge {  get; set; }
        public bool validLicense { get; set; }

        public User (int userAge, bool validLicense)
        {
            this.userAge = userAge;
            this.validLicense = validLicense;
        }

        public void IsUserAllowedToDrive()
        {
           if (userAge >= 18 && validLicense == true)
            {
                Console.WriteLine("User is allowed to drive");
            }
           else
            {
                Console.WriteLine("User is not allowed to drive");
            }
                
        }
    }
}
