using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValidTest()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Lakshmi",
            LastName = "Patel"
        };
            string expected = "Patel, Lakshmi";

            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
