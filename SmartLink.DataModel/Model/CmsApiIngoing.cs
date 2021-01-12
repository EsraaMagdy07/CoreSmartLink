using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsApiIngoing
    {
        public int Id { get; set; }
        public int? ConversationId { get; set; }
        public string Reference { get; set; }
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public string FromName { get; set; }
        public string MsgText { get; set; }
        public string MsgUrl { get; set; }
        public string ContantType { get; set; }
        public DateTime MsgTime { get; set; }
        public DateTime InsertionDateTime { get; set; }
        public string Channel { get; set; }
        public string OptionChoice { get; set; }
        public string SongName { get; set; }
        public string ArtistName { get; set; }
    }
}
