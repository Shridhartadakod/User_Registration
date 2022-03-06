using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration_TestMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration program:");
            Console.WriteLine("==========Welcome To User Registration===========");
            //Creating object od class
            Registration registration = new Registration();
            registration.FirstName();
            registration.LastName();
            registration.EmailId();
            registration.MobileNumber();
            registration.Password();

            Console.ReadKey();
        }
    }
}
