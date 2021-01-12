using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsTrack
    {
        public int Id { get; set; }
        public int? FileDataId { get; set; }
        public int? Duration { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual CmsFileData FileData { get; set; }
    }
}
