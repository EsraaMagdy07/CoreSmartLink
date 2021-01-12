using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformDistributor
    {
        public PlatformDistributor()
        {
            PlatformList = new HashSet<PlatformList>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<PlatformList> PlatformList { get; set; }
    }
}
