using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMe.BizLayer
{
    class BizLogic
    {
        public Contact GetContact(string phoneNumber)
        {
            //TODO: Validate phone no
            if(string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentNullException("Phone no cannot be empty.");
            }

            Contact contact = new Contact(phoneNumber);
            //TODO: Search from database with the phone no.
            //set the contact properties with the database values.
            return contact;
        }

        public void AddContact(Contact contact)
        {
            //TODO: Add the Contact to the DB
            //TODO: If the Contact cannot be added throw an exception
        }

        public void RemoveContact(string phoneNumber)
        {
            //TODO: Remove the Contact from the DB corresponding to the phoneNumber
            //TODO: If the Contact cannot be added throw an exception
        }

        public void UpdateContactTag(string phoneNumber,string tag)
        {
            //TODO: Update tag
            //TODO: If the tag cannot be updated throw an exception
        }

        public void UpdateContactFullName(string phoneNumber, string fullName)
        {
            //TODO: Update FullName
            //TODO: If the fullName cannot be updated throw an exception
        }

        public void UpdateContactAddress(string phoneNumber, string address)
        {
            //TODO: Update Address
            //TODO: If the address cannot be updated throw an exception
        }

        public void UpdateContactEmail(string phoneNumber, string Email)
        {
            //TODO: Update Email
            //TODO: If the email cannot be updated throw an exception
        }

        public void UpdateContactPhoto(string phoneNumber, byte[] photo)
        {
            //TODO: Update Photo
            //TODO: If the photo cannot be updated throw an exception
        }














    }
}
