using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ContentHyperLinks
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int ChannelId { get; set; }
        public string Url { get; set; }

        public virtual Channel1 Channel { get; set; }
        public virtual Content1 Content { get; set; }
    }
}
