using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ChannelTypes
    {
        public ChannelTypes()
        {
            Channel1 = new HashSet<Channel1>();
        }

        public byte Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }

        public virtual ICollection<Channel1> Channel1 { get; set; }
    }
}
