using SwissCreate.Core.Domain.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Data.Mapping.Email
{
    public class MessageQueueMap : SwissCreateEntityTypeConfiguration<MessageQueue>
    {
        public MessageQueueMap()
        {
            this.ToTable("MessageQueue");
            this.HasKey(mq => mq.Id);
        }
    }
}
