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


        //Creating method to check validation
        public bool Validate(string info, string Pattern)
        {
            return Regex.IsMatch(info, Pattern);
        }
    }
}
