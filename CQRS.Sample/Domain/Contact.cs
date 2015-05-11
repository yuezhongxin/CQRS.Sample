using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Sample.Domain
{
    public class Contact
    {
        public Contact()
        {
        }

        public Contact(int id, string displayName)
        {
            this.Id = id;
            this.DisplayName = displayName;
        }

        public int Id { get; private set; }
        public string DisplayName { get; private set; }
    }
}
