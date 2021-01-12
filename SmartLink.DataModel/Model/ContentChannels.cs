using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ContentChannels
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int ChannelId { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual Content Content { get; set; }
    }
}
