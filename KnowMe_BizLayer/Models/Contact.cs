using System.Collections.Generic;

namespace KnowMe.BizLayer
{
    public class Contact
    {
        public List<string> Tags { get; set; }

        public byte[] Photo { get; set; }

        public string Email { get; set; }

        public string RegisteredName { get; set; }

        public string FullName { get; set; }

        public bool IsSpam { get; set; }

        public List<Spam> Spams { get; private set; }

        public string PhoneNumber { get; private set; }

        public List<Contact_Frequency> ContactFrequencies { get; set; }

        public string Address { get; set; }

        public Contact(string Phone_number)
        {
            this.PhoneNumber =Phone_number;
           
        }
    }
}
