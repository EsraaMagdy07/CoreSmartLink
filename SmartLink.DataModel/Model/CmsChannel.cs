using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsChannel
    {
        public CmsChannel()
        {
            CmsProviderContentChannelRel = new HashSet<CmsProviderContentChannelRel>();
        }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }
        public int? CmsChannelCategoryId { get; set; }

        public virtual ICollection<CmsProviderContentChannelRel> CmsProviderContentChannelRel { get; set; }
    }
}
