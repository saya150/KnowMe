using System;

namespace KnowMe.BizLayer
{
    public class Contact_Frequency
    {
        public string FirstName { get; private set; }
        
        public string LastName { get; set; }

        public DateTime Date { get; private set; }

        public Contact_Frequency(string FName,DateTime date)
        {
            this.FirstName = FName;
            this.Date = date;
        }
    }
}
