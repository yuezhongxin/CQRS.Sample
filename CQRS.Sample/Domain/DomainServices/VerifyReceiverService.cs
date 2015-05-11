using CQRS.Sample.Commands;
using CQRS.Sample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Sample.Domain.DomainServices
{
    public class VerifyReceiverService
    {
        public static Contact Verify(string recipientDisplayName)
        {
            //Contact receiver = new ContactRepository().GetContactByDisplayName(recipientDisplayName);
            //if (receiver == null)
            //{
            //    throw new InvalidOperationException("抱歉！发送失败！错误：收件人不存在");
            //}
            //return receiver;
            return new Contact(2, "2");
        }
    }
}
