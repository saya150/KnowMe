using System;

namespace KnowMe.BizLayer
{
    public class Contact_Frequency
    {
        public string FirstName { get; private set; } // validate isnullorwhitespace
        
        public string LastName { get; set; }

        public DateTime Date { get; private set; }

        public Contact_Frequency(string FName,DateTime date)
        {
            //validate here
            this.FirstName = FName;
            this.Date = date;
        }
    }
}
