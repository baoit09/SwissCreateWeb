using SwissCreate.Core.Domain.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Data.Mapping.Email
{
    public class MessageQueue_HistoryMap : SwissCreateEntityTypeConfiguration<MessageQueue_History>
    {
        public MessageQueue_HistoryMap()
        {
            this.ToTable("MessageQueue_History");
            this.HasKey(mqh => mqh.Id);
        }
    }
}
