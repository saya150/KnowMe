using System;
using System.Text.RegularExpressions;

namespace KnowMe.BizLayer
{
    public class ContactValidator
    {
        public bool IsValidPhoneNumber(string phoneNumber) 
        {
            string PhoneNumber1 = @"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$";
            string PhoneNumber2 = @"^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$";
            if (Regex.IsMatch(phoneNumber, PhoneNumber1) || Regex.IsMatch(phoneNumber, PhoneNumber2)) 

            {
                return true;
                
            }
        
            throw new FormatException("Invalid phone number");
        }
    }
}
