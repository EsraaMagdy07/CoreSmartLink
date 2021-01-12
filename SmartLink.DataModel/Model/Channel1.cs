using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Channel1
    {
        public Channel1()
        {
            AlbumHyperLinks = new HashSet<AlbumHyperLinks>();
            ContentHyperLinks = new HashSet<ContentHyperLinks>();
        }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DisplayName { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }
        public string LogoPath { get; set; }
        public byte? ChannelTypeId { get; set; }
        public short? DisplayOrder { get; set; }

        public virtual ChannelTypes ChannelType { get; set; }
        public virtual ICollection<AlbumHyperLinks> AlbumHyperLinks { get; set; }
        public virtual ICollection<ContentHyperLinks> ContentHyperLinks { get; set; }
    }
}
