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
        public const string NAME_PATTERN = @"^[A-Z][a-zA-Z]{2,}$";
        public const string EMAIL_PATTERN = @"^[A-Za-z0-9]{3,}([\.\-\+][A-Za-z0-9]{3,})?[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2,})?$";
        public const string MOBILE_PATTERN = @"^[0-9]{2}[ ][0-9]{10}$";
        public const string PASSWORD_PATTERN = @"^(?!.*[!@#&()–\[{}\]:;',?/*~$^+=<>].*[!@#&()–\[{}\]:;',?/*~$^+=<>])(?=.*[A-Z])(?=.*[0-9]).{8,}$";

        // Registration details of user
        private string firstName;
        private string lastName;
        private string email;
        private string mobile;
        private string password;

        /// <summary>
        /// Gets the information from user.
        /// </summary>
        public void GetInfo()
        {
            firstName = GetValidInfo("First Name: ", NAME_PATTERN);
            lastName = GetValidInfo("Last Name: ", NAME_PATTERN);
            email = GetValidInfo("Email: ", EMAIL_PATTERN);
            mobile = GetValidInfo("Mobile: ", MOBILE_PATTERN);
            password = GetValidInfo("Password: ", PASSWORD_PATTERN);
        }

        /// <summary>
        /// Gets the valid information from user.
        /// <para>based on the pattern, this ensures the user enters valid info pattern</para>
        /// </summary>
        /// <returns>A valid info string</returns>
        private static string GetValidInfo(string message, string pattern)
        {
            string info;
            try
            {
                do
                {
                    Console.Write(message);
                    info = Console.ReadLine();
                    if (IsValid(info, pattern))
                        return info;
                    else
                        Console.WriteLine("Invalid!");
                } while (true);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Cannot give empty or null information");
            }
            catch
            {
                Console.WriteLine("Unkown error occured");
            }
            return null;
        }

        //Creating method to check validation
        public bool Validate(string info, string Pattern)
        {
            return Regex.IsMatch(info, Pattern);
        }
    }
}
