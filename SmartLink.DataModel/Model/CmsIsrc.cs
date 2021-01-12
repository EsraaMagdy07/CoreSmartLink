using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsIsrc
    {
        public int Id { get; set; }
        public int? TrackId { get; set; }
        public string Isrc { get; set; }
        public DateTime? InsertionDate { get; set; }
    }
}
