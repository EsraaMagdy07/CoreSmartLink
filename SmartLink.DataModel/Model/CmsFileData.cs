using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsFileData
    {
        public CmsFileData()
        {
            CmsImage = new HashSet<CmsImage>();
            CmsTrack = new HashSet<CmsTrack>();
        }

        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string TypeExt { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual ICollection<CmsImage> CmsImage { get; set; }
        public virtual ICollection<CmsTrack> CmsTrack { get; set; }
    }
}
