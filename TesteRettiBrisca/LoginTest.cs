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
            var username = "Pitic";
            var password = "carmen123";

            // Act
            Boolean result = logIn.LoginUser(username, password);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
