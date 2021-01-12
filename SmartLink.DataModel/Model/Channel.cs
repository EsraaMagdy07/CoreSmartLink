using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Channel
    {
        public Channel()
        {
            ContentChannels = new HashSet<ContentChannels>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }

        public virtual ICollection<ContentChannels> ContentChannels { get; set; }
    }
}
