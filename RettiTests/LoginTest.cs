using RettiBrisca;

namespace RettiTests
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestCorrectCredentials()
        {
            // Arrange
            var loginForm = new LogIn();
            var username = "Pitic";
            var password = "carmen123";

            // Act
            Boolean result = loginForm.LoginUser(username, password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIncorrectCredentials()
        {
            // Arrange
            var loginForm = new LogIn();
            var username = "Pitic";
            var password = "incorrectpassword";

            // Act
            Boolean result = loginForm.LoginUser(username, password);

            // Assert
            Assert.IsFalse(result);
        }
    }
}