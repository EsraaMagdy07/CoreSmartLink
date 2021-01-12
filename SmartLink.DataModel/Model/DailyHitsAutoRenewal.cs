using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class DailyHitsAutoRenewal
    {
        public int Id { get; set; }
        public DateTime? DayDate { get; set; }
        public int? PlatformId { get; set; }
        public int? ProviderId { get; set; }
        public int? ProviderDataId { get; set; }
        public string ProviderName { get; set; }
        public string ToneCode { get; set; }
        public string SingerName { get; set; }
        public string SongName { get; set; }
        public int? Hits { get; set; }
        public decimal? PricePerHit { get; set; }
        public decimal? RevenuePerHit { get; set; }
        public decimal? PostPaidRevenue { get; set; }
        public decimal? PrePaidRevenue { get; set; }
        public int? NoTrx { get; set; }
        public int? UserId { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public bool? NeedAction { get; set; }
        public string ActionDescription { get; set; }
        public int? OldProviderId { get; set; }
        public string OldProviderName { get; set; }
        public int? OldProivderDataId { get; set; }
        public string UploadedProviderName { get; set; }
        public int? HoldedProviderId { get; set; }
        public bool? Checked { get; set; }
        public bool? Collected { get; set; }
        public bool? Paid { get; set; }
        public bool? Released { get; set; }
        public string ProviderInfo { get; set; }
        public bool? LocalContent { get; set; }
        public bool? IsArabic { get; set; }
        public string OldUploadedProviderName { get; set; }
        public int? OldHoldProviderId { get; set; }
        public decimal? UploadedRevenue { get; set; }
        public decimal? RenewalTimes { get; set; }
        public decimal? RenewalIncome { get; set; }
        public bool? IsPrePaid { get; set; }
    }
}
