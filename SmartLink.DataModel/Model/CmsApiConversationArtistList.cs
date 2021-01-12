using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsApiConversationArtistList
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Number { get; set; }
        public string OptionChoise { get; set; }
        public string ArtistName { get; set; }
        public int? ConversationId { get; set; }
    }
}
