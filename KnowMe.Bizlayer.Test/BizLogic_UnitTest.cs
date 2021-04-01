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
        public void GetContact_PhoneNumberIsNull_GetNullExceptionBack()
        {   //Arrange
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = null;
            bizlogic.GetContact(PhoneNumber);

            //Assert

        }
        //+ 2 tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetContact_PhoneNumberIsWhiteSpace_GetNullExceptionBack()
        {   //Arrange
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = " ";
            bizlogic.GetContact(PhoneNumber);

            //Assert

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetContact_PhoneNumberIsBlank_GetNullExceptionBack()
        {   //Arrange
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber ="";
            bizlogic.GetContact(PhoneNumber);

            //Assert

        }


        [TestMethod]
       
        public void GetContact_ContactInstance_NotActual()
        {
            //Arrange
            var target = new BizLogic();

            //Act
            Contact actual = target.GetContact("923456789");

            //Assert
            Assert.IsNotNull(actual);  
            Assert.IsInstanceOfType(actual, typeof(Contact));
        }

        //test if the phone no is same as sent
        [TestMethod]
        
        public void GetContact_IsPhoneNumberEqual_GetExceptionBack()
        {
            //Arrange
            var target = new BizLogic();

            //Act
            Contact actual = target.GetContact("923456789");

            //Assert
            Assert.AreEqual("923456789", actual);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddContact_PhoneNumberIsNull_GetNullExceptionBack()
        {   //Access
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber =null;
            Contact contact = new Contact(PhoneNumber);
            bizlogic.AddContact(contact);
   
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddContact_PhoneNumberIsWhiteSpace_GetNullExceptionBack()
        {   //Access
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber =" ";
            Contact contact = new Contact(PhoneNumber);
            bizlogic.AddContact(contact);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddContact_PhoneNumberIsBlank_GetNullExceptionBack()
        {   //Access
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = "";
            Contact contact = new Contact(PhoneNumber);
            bizlogic.AddContact(contact);

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteContact_PhoneNumberIsNull_GetNullExceptionBack()
        {
            //Arrange
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber =null;
            bizlogic.DeleteContact(PhoneNumber);

            //Assert

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteContact_PhoneNumberIsWhiteSpace_GetNullExceptionBack()
        {
            //Arrange
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = " ";
            bizlogic.DeleteContact(PhoneNumber);

            //Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteContact_PhoneNumberIsBlank_GetNullExceptionBack()
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

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UpdateContact_PhoneNumberIsNull_GetNullExceptionBack()
        {
            //Access
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber =null;
            Contact contact = new Contact(PhoneNumber);
            bizlogic.UpdateContact(contact);

            //Assert

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UpdateContact_PhoneNumberIsWhiteSpace_GetNullExceptionBack()
        {
            //Access
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = " ";
            Contact contact = new Contact(PhoneNumber);
            bizlogic.UpdateContact(contact);

            //Assert

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UpdateContact_PhoneNumberIsBklank_GetNullExceptionBack()
        {
            //Access
            var bizlogic = new BizLogic();

            //Act
            string PhoneNumber = "";
            Contact contact = new Contact(PhoneNumber);
            bizlogic.UpdateContact(contact);

            //Assert

        }

    }
}
