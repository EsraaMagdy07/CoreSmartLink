using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsArtist
    {
        public CmsArtist()
        {
            CmsAlbum = new HashSet<CmsAlbum>();
            CmsContent = new HashSet<CmsContent>();
            CmsContentTemp = new HashSet<CmsContentTemp>();
        }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string NameEnDisplay { get; set; }
        public int? ImageId { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual CmsImage Image { get; set; }
        public virtual ICollection<CmsAlbum> CmsAlbum { get; set; }
        public virtual ICollection<CmsContent> CmsContent { get; set; }
        public virtual ICollection<CmsContentTemp> CmsContentTemp { get; set; }
    }
}
