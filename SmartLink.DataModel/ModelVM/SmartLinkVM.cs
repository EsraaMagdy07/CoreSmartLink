using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLink.DataModel.ModelVM
{
   public class SmartLinkVM
    {
        public string ArtistName { get; set; }
        public string ContentName { get; set; }
        public string AlbumName { get; set; }
        public string TrackUrl { get; set; }
        public string ImageUrl { get; set; }
        public int ContentId { get; set; }
        public List<ChannelVM> Channels { get; set; }
    }
}
