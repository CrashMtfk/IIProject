using System.Globalization;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RettiBrisca;

namespace TesteRettiBrisca
{
    [TestClass]
    public class AppointmentClass
    {
        [TestMethod]
        public void TestCorrectAppointment()
        {
            // Arrange
            MakeAppointment mapp = new MakeAppointment();
            string numeFrizer = "Retti Brisca";

            string username = "mihair";
            string dateString = "5/20/2025 5:20 PM";
            DateTime dt = DateTime.ParseExact(dateString, "M/d/yyyy h:mm tt", CultureInfo.InvariantCulture);

            // Act
            Boolean result = mapp.AppointmentT(numeFrizer, dt,username);

            // Assert
            Assert.IsTrue(result);
        }
    }
}

