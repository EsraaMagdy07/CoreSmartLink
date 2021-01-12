using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PromotionContents
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ToneCode { get; set; }
        public string ToneName { get; set; }
        public string SingerName { get; set; }
        public int? PlatformId { get; set; }
        public decimal? Price { get; set; }
    }
}
