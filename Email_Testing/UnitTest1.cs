using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_TestMethod;
namespace Email_Testing
{
    [TestClass]
    public class EmailTest
    {
        //Pattern for validation  of email id
        string emailPattern = @"^[A-Za-z0-9+-]{3,}([.][A-Za-z0-9]{3,})?[@][a-zA-Z0-9]{1,}([.][a-zA-Z]{2,})([.][a-zA-Z]{2,})?$";

        [TestMethod]
        [DataRow(@"abc@yahoo.com")]
        [DataRow(@"abc-100@yahoo.com")]
        [DataRow(@"abc.100@yahoo.com")]
        [DataRow(@"abc111@abc.com")]
        [DataRow(@"abc-100@abc.net")]
        [DataRow(@"abc.100@abc.com.au")]
        [DataRow(@"abc@1.com")]
        [DataRow(@"abc@gmail.com.com")]
        [DataRow(@"abc+100@gmail.com")]

        //Creating method to check valid emails
        public void TestValidEmails(string email)
        {
            var result = User_Registration_TestMethod.Validate(email, emailPattern);
            Assert.IsTrue(result);
        }


        [TestMethod]
        [DataRow(@"abc")]
        [DataRow(@"abc@.com.my")]
        [DataRow(@"abc123@gmail.a")]
        [DataRow(@"abc123@.com")]
        [DataRow(@"abc123@.com.com ")]
        [DataRow(@".abc@abc.com")]
        [DataRow(@"abc()*@gmail.com")]
        [DataRow(@"abc@%*.com")]
        [DataRow(@"abc..2002@gmail.com")]
        [DataRow(@"abc.@gmail.com")]
        [DataRow(@"abc@abc@gmail.com")]
        [DataRow(@"abc@gmail.com.1a")]
        [DataRow(@"abc@gmail.com.aa.au")]

        //Creating method to check invalid emails
        public void TestInvalidEmails(string email)
        {
            var result = User_Registration_TestMethod.Validate(email, emailPattern);
            Assert.IsFalse(result);
        }
    }
}