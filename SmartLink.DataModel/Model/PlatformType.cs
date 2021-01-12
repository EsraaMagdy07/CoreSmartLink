using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformType
    {
        public PlatformType()
        {
            AccountManager = new HashSet<AccountManager>();
            PlatformList = new HashSet<PlatformList>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CmsChannelId { get; set; }
        public int? LoginId { get; set; }
        public string Color { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<AccountManager> AccountManager { get; set; }
        public virtual ICollection<PlatformList> PlatformList { get; set; }
    }
}
