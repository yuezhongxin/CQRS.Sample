using CQRS.Sample.Commands;
using CQRS.Sample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Sample.Domain.DomainServices
{
    public class VerifySenderService
    {
        public static Contact Verify(string senderLoginName)
        {
            //Contact sender = new ContactRepository().GetContactByLoginName(senderLoginName);
            //if (sender == null)
            //{
            //    throw new InvalidOperationException("抱歉！发送失败！错误：发件人不存在");
            //}
            ////if (UserService.GetGaggedByLoginName(senderLoginName))
            //if (false)
            //{
            //    throw new InvalidOperationException("您好，您的帐户暂时无法发送站内短消息");
            //}
            //if (new MessageRepository().Query<Message>().Where(m => m.IP == "1.1.1.1").Count() > 100)
            //{
            //    throw new InvalidOperationException("一天内只能发送100条短消息");
            //}
            //if (new MessageRepository().Query<Message>().Where(m => m.Sender.Id == sender.Id).Count() > 20)
            //{
            //    throw new InvalidOperationException("1小时内只能向20个不同的用户发送短消息");
            //}
            //return sender;
            return new Contact(1, "1");
        }
    }
}
