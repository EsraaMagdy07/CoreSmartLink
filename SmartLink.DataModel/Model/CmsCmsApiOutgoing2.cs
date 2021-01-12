using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsCmsApiOutgoing2
    {
        public int Id { get; set; }
        public string ToNumber { get; set; }
        public string FromName { get; set; }
        public string ContentMsg { get; set; }
        public string AllowedChannel { get; set; }
        public DateTime InsertionDate { get; set; }
        public string Reference { get; set; }
        public int? ConversationId { get; set; }
    }
}
