using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RettiBrisca;

namespace TesteRettiBrisca
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestCorrectCredentials()
        {
            // Arrange
            LogIn logIn = new LogIn();
            var username = "mihair";
            var password = "password";

            // Act
            Boolean result = logIn.LoginUser(username, password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestFailedCredentials()
        {
            // Arrange
            LogIn logIn = new LogIn();
            var username = "tester";
            var password = "tester12";

            // Act
            Boolean result = logIn.LoginUser(username, password);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
