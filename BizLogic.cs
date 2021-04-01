using System;

namespace KnowMe.BizLayer
{
   public class BizLogic
    {
        //IRepository Repository;

        //public BizLogic(IRepository repository)
        //{
        //    Repository = repository;
        //}

        public Contact GetContact(string phoneNumber)
        {
            ContactValidator contactValidator = new ContactValidator();
            //contactValidator.IsValidPhoneNumber(phoneNumber);
            //TODO: Validate phone no
            if(string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentNullException("Phone no cannot be empty.");
            }

            Contact contact = new Contact(phoneNumber);
            //TODO: Search from database with the phone no.
            //set the contact properties with the database values.
            //return Repository.GetContact(phoneNumber);
            return contact;
        }

        //write all the +tive and -tive tests for contact validator

        public void AddContact(Contact contact)
        {
            if (string.IsNullOrWhiteSpace(contact.PhoneNumber))
            {
                throw new ArgumentNullException("Phone no cannot be empty.");
            }
           
            //TODO: Add the Contact to the DB
            //TODO: If the Contact cannot be added throw an exception
        }

        public void DeleteContact(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentNullException("Phone no cannot be empty.");
            }
            //TODO: Remove the Contact from the DB corresponding to the phoneNumber
            //TODO: If the Contact cannot be deleted throw an exception
        }

        public void UpdateContact(Contact contact)
        {
            if (string.IsNullOrWhiteSpace(contact.PhoneNumber))
            {
                throw new ArgumentNullException("Phone no cannot be empty.");
            }

            //TODO: If the contact cannot be updated throw an exception
        }

    }
}
