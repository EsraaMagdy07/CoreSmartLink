using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class MonthlySummerization
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public DateTime? MonthDate { get; set; }
        public string Month { get; set; }
        public int? CountryId { get; set; }
        public string Country { get; set; }
        public int? PlatformId { get; set; }
        public string PlatfromName { get; set; }
        public decimal? RevenueShare { get; set; }
        public int? Hits { get; set; }
        public decimal? TotalRevenue { get; set; }
        public decimal? Cost { get; set; }
        public decimal? HoldCost { get; set; }
        public DateTime? InsertedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public bool? Collected { get; set; }
        public bool? Paid { get; set; }
        public bool? ConfirmedInvoice { get; set; }
    }
}
