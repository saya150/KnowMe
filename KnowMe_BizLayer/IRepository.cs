using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMe.BizLayer
{
    public interface IRepository
    {
        Contact GetContact(string PhoneNo);

        void AddContact(Contact contact);

        void DeleteContact(string phoneNumber);

        void UpdateContact(Contact contact);
    }
}
