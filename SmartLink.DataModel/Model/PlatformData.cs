using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformData
    {
        public int Id { get; set; }
        public int? PlatformId { get; set; }
        public int? StartMonth { get; set; }
        public int? StartYear { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public int? CountryId { get; set; }
        public decimal? BadDebt { get; set; }
        public decimal? Taxes { get; set; }
        public decimal? TaxesPostPaid { get; set; }
        public decimal? TaxesPrePaid { get; set; }
        public decimal? TaxesProviders { get; set; }
        public decimal? RevenueShare { get; set; }
        public string Notes { get; set; }

        public virtual Territory Country { get; set; }
        public virtual PlatformList Platform { get; set; }
    }
}
