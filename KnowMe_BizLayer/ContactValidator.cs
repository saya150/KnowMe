﻿using System;
using System.Text.RegularExpressions;

namespace KnowMe.BizLayer
{
    class ContactValidator
    {
        protected bool PhoneNumber_Validator(string phoneNumber) 
        {
            string PhoneNumber = "^(?:(?:\\+?1\\s*(?:[.-]\\s*)?)?(?:\\(\\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\\s*\\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\\s*(?:[.-]\\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\\s*(?:[.-]\\s*)?([0-9]{4})(?:\\s*(?:#|x\\.?|ext\\.?|extension)\\s*(\\d+))?$";
            if (!Regex.IsMatch(phoneNumber, PhoneNumber)) 
            {
                throw new FormatException("Invalid phone number");
            }

            return Regex.IsMatch(phoneNumber, PhoneNumber);

        }
    }
}
