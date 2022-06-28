using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopBaseballBats;
using ShopBaseballBats.Models;

namespace ShopBaseballBats.BLTest
{
    [TestClass]
    public class CustomerTest
    {
       
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer();
            { customer.FirstName = "George"; customer.LastName = "Washington"; }
            string expected = "Washington, George";
            //--Act
            string actual = customer.FullName;
            //--Assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            { customer.LastName = "Washington";}
            string expected = "Washington";
            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            { customer.FirstName = "George"; }
            string expected = "George";
            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
    }
}