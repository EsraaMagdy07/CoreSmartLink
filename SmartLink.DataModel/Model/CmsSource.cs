using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsSource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }
        public bool? ContainArabicData { get; set; }
    }
}
