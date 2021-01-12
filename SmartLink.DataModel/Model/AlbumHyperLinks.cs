using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AlbumHyperLinks
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public int ChannelId { get; set; }
        public string Url { get; set; }

        public virtual Album Album { get; set; }
        public virtual Channel1 Channel { get; set; }
    }
}
