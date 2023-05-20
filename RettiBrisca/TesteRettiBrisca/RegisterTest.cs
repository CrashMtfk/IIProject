using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RettiBrisca;

namespace TesteRettiBrisca
{
    [TestClass]
    public class RegisterTest
    {
        [TestMethod]
        public void TestCorrectRegister()
        {
            // Arrange
            Register reg = new Register();
            var username = "tester1234567";
            var password = "tester123456";
            var fullName = "tester tester";
            var phoneNumber = "0712345678";

            // Act
            Boolean result = reg.RegisterUser(username, password,fullName,phoneNumber);

            // Assert
            Assert.IsTrue(result);
           
    }

        [TestMethod]
        public void TestFailedRegister()
        {
            // Arrange
            Register reg = new Register();
            var username = "tester123456";
            var password = "tester123456";
            var fullName = "tester tester";
            var phoneNumber = "0712345678";

            // Act
            Boolean result = reg.RegisterUser(username, password, fullName, phoneNumber);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
