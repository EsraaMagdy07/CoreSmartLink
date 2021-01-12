using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsAlbum
    {
        public CmsAlbum()
        {
            CmsContentTemp = new HashSet<CmsContentTemp>();
        }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? ImageId { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }
        public int? ReleaseYear { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? CmsArtistId { get; set; }

        public virtual CmsArtist CmsArtist { get; set; }
        public virtual CmsImage Image { get; set; }
        public virtual ICollection<CmsContentTemp> CmsContentTemp { get; set; }
    }
}
