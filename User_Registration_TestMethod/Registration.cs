using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_TestMethod
{
    public class Registration
    {
        public void FirstName()
        {
            Console.Write("Enter the name = ");
            string name = Console.ReadLine();
            string Pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Validate(name, Pattern))
                Console.WriteLine("The entered name is valid!!");
            else
                Console.WriteLine("Please enter the valid name..");
        }

        //Creating method to check validation for last name
        public void LastName()
        {
            Console.WriteLine("Enter the last name = ");
            string name = Console.ReadLine();
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            if (Validate(name, pattern))
                Console.WriteLine("The entered last name is valid!!");
            else
                Console.WriteLine("Please enter the valid last name..");
        }

        //Creating method to check validation for email id
        public void EmailId()
        {
            Console.Write("Enter the email id = ");
            string emailId = Console.ReadLine();
            string pattern = "^[A-Za-z0-9]{3,}([.][A-Za-z0-9]{3,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";

            if (Validate(emailId, pattern))
                Console.WriteLine("The entered email id is valid!!");
            else
                Console.WriteLine("Please enter the valid email id..");
        }

        //Creating method to check validation for mobile number
        public void MobileNumber()
        {
            Console.WriteLine("Enter the mobile number = ");
            string mobileNumber = Console.ReadLine();
            string pattern = "^([0-9]{2}[ ]){0,1}[0-9]{10}$";

            if (Validate(mobileNumber, pattern))
                Console.WriteLine("The entered mobile number is valid!!");
            else
                Console.WriteLine("Please enter the valid mobile number..");
        }


        public void Password()
        {
            Console.WriteLine("Enter the password = ");
            string password = Console.ReadLine();
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])(A-Za-z\d$!$%*?&]{8,}$";

            if (Validate(password, pattern))
                Console.WriteLine("The entered password is valid!!");
            else
                Console.WriteLine("Please enter the valid password..");
        }


        //Creating method to check validation
        public bool Validate(string info, string Pattern)
        {
            return Regex.IsMatch(info, Pattern);
        }
    }
}
