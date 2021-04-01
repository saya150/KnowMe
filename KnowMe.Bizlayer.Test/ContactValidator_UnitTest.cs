using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnowMe.BizLayer;
using System;

namespace KnowMe.Bizlayer.Test
{
    [TestClass]
    public class ContactValidator_UnitTest
    {
        
        //ALL THE POSITIVE TEST CASES
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive1_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "9345678961";
            
            bool actual= contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive2_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "03342345678";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive3_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "+1 800 555-1234";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive4_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "1-800-555-1234";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive5_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "(800)555-1234";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive6_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "800.555.1234";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive7_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "18005551234";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive8_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "8005551234 x5678";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive9_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "+918880344456";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive10_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "918880344456";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsValidPhoneNumber_IsValidPositive11_GetTrueBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "6294308020";

            bool actual = contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            Assert.IsTrue(actual);
        }



        //ALL THE NEGATIVE TEST CASES
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValidPhoneNumber_IsNull_GetNullExceptionBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = null;

            //Assert
            contactValidator.IsValidPhoneNumber(PhoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void IsValidPhoneNumber_IsWhiteSpace_GetExceptionBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = " ";

            //Assert
            contactValidator.IsValidPhoneNumber(PhoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void IsValidPhoneNumber_IsBlank_GetExceptionBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "";

            //Assert
            contactValidator.IsValidPhoneNumber(PhoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void IsValidPhoneNumber_IsValidNegative_GetExceptionBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "033----)4(567896";

            contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            //Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void IsValidPhoneNumber_IsValidNegCaseLetters_GetExceptionBack()
        {
            //Arrange
            var contactValidator = new ContactValidator();
            //Act
            string PhoneNumber = "abcdwf";

            contactValidator.IsValidPhoneNumber(PhoneNumber);
            //Assert
            //Assert.IsTrue(actual);
        }

    }
}
