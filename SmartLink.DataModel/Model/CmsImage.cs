using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsImage
    {
        public CmsImage()
        {
            CmsAlbum = new HashSet<CmsAlbum>();
            CmsArtist = new HashSet<CmsArtist>();
            CmsContent = new HashSet<CmsContent>();
        }

        public int Id { get; set; }
        public int? FileDataId { get; set; }
        public int? Width { get; set; }
        public int? High { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual CmsFileData FileData { get; set; }
        public virtual ICollection<CmsAlbum> CmsAlbum { get; set; }
        public virtual ICollection<CmsArtist> CmsArtist { get; set; }
        public virtual ICollection<CmsContent> CmsContent { get; set; }
    }
}
