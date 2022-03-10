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
            Console.WriteLine("Using Reflection to enter Registration form for a new user");
            try
            {
                Type type = typeof(Registration);
                var form = Activator.CreateInstance(type);
                MethodInfo methodInfo = type.GetMethod("GetInfo");
                methodInfo.Invoke(form, null);
            }
            catch
            {
                Console.WriteLine("Reflection failed");
            }

            Console.ReadKey();
        }
    }
}
