using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsExclusivity
    {
        public CmsExclusivity()
        {
            CmsContent = new HashSet<CmsContent>();
            CmsContentTemp = new HashSet<CmsContentTemp>();
        }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual ICollection<CmsContent> CmsContent { get; set; }
        public virtual ICollection<CmsContentTemp> CmsContentTemp { get; set; }
    }
}
