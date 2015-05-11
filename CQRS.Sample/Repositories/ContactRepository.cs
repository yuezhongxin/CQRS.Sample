using CQRS.Sample.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Sample.Domain;

namespace CQRS.Sample.Repositories
{
    public class ContactRepository
    {
        internal Contact GetContactByDisplayName(string recipientDisplayName)
        {
            throw new NotImplementedException();
        }

        internal Contact GetContactByLoginName(string senderLoginName)
        {
            throw new NotImplementedException();
        }
    }
}
