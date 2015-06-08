using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Core.Domain.Email
{
    public class EmailTemplate : BaseEntity
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AttachmentFiles { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
