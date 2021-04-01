using System;

namespace KnowMe.BizLayer
{
    public class Spam
    {
        public string ReportingNumber { get; private set; }

        public DateTime Timestamp { get; private set; }

        public Spam(string ReportingNumber, DateTime Timestamp)
        {
            //validate here
            this.ReportingNumber = ReportingNumber;
            this.Timestamp = Timestamp;
        }
    }
}
