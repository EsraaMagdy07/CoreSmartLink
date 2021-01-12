using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsApiConversationProcessStep
    {
        public int Id { get; set; }
        public int? ConversationId { get; set; }
        public string Number { get; set; }
        public int? ProcessStepId { get; set; }
    }
}
