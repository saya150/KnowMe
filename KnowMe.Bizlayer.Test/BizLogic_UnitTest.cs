using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnowMe.BizLayer;
using System;

namespace KnowMe.Bizlayer.Test
{
    [TestClass]
    public class BizLogic_UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetContact_PhoneNumberIsNullorWhiteSpace_GetNullExceptionBack()
        {   //Arrange
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = "";
            bizlogic.GetContact(PhoneNumber);

            //Assert
           
        }

        [TestMethod]
        public void GetContact_ContactInstance_NotActual()
        {
            //Arrange
            var target = new BizLogic();

            //Act
            Contact actual = target.GetContact("1234");

            //Assert
            Assert.IsNotNull(actual);  
            Assert.IsInstanceOfType(actual, typeof(Contact));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddContact_PhoneNumberIsNullorWhiteSpace_GetNullExceptionBack()
        {   //Access
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = " ";
            Contact contact = new Contact(PhoneNumber);
            bizlogic.AddContact(contact);
   
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteContact_PhoneNumberIsNullorWhiteSpace_GetNullExceptionBack()
        {
            //Arrange
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = "";
            bizlogic.DeleteContact(PhoneNumber);

            //Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UpdateContact_PhoneNumberIsNullorWhiteSpace_GetNullExceptionBack()
        {
            //Access
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = " ";
            Contact contact = new Contact(PhoneNumber);
            bizlogic.UpdateContact(contact);

            //Assert

        }

    }
}
