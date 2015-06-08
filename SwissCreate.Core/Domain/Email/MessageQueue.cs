using System;
using System.ComponentModel.DataAnnotations;

namespace SwissCreate.Core.Domain.Email
{
    public class MessageQueue : BaseEntity
    {
        public DateTime Date_Send { get; set; }
        public int Priority { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public int RetryNumber { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public byte[] Attachments { get; set; }
        public bool IsCombined { get; set; }
        public string SendStatus { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
