using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsCatalog
    {
        public CmsCatalog()
        {
            CmsContentTemp = new HashSet<CmsContentTemp>();
            UserContent = new HashSet<UserContent>();
        }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? ImageId { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual ICollection<CmsContentTemp> CmsContentTemp { get; set; }
        public virtual ICollection<UserContent> UserContent { get; set; }
    }
}
