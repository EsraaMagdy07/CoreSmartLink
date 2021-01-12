using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformCollections
    {
        public int Id { get; set; }
        public int? PlatformId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? Amount { get; set; }
        public int? CurrecnyId { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public bool? Collected { get; set; }
        public DateTime? CollectedDatetime { get; set; }
        public int? UserId { get; set; }
    }
}
