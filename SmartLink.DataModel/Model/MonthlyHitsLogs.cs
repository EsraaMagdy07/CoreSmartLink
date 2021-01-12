using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class MonthlyHitsLogs
    {
        public int Id { get; set; }
        public DateTime LogDateTime { get; set; }
        public int? DataId { get; set; }
        public int? YearDate { get; set; }
        public int? MonthDate { get; set; }
        public int? PlatformId { get; set; }
        public int? ProviderIdOld { get; set; }
        public int? ProviderDataIdOld { get; set; }
        public string ProviderNameOld { get; set; }
        public int? ProviderIdNew { get; set; }
        public int? ProviderDataIdNew { get; set; }
        public string ProviderNameNew { get; set; }
        public string ToneCode { get; set; }
        public string SingerName { get; set; }
        public string SongName { get; set; }
        public int? Hits { get; set; }
        public decimal? PricePerHit { get; set; }
        public decimal? RevenuePerHit { get; set; }
        public decimal? PostPaidRevenue { get; set; }
        public decimal? PrePaidRevenue { get; set; }
        public int? NoTrx { get; set; }
        public int? UserIdOld { get; set; }
        public int? UserIdNew { get; set; }
        public int? SuperUserIdOld { get; set; }
        public int? SuperUserIdNew { get; set; }
        public DateTime? DataInsertionDateTime { get; set; }
        public DateTime? DataModificationDateTime { get; set; }
        public bool? AllowToUpdate { get; set; }
        public bool? Reviewied { get; set; }
        public bool? Checked { get; set; }
        public bool? NeedActionOld { get; set; }
        public bool? NeedActionNew { get; set; }
        public string ActionDescriptionOld { get; set; }
        public string ActionDescriptionNew { get; set; }
        public int? OldProviderId { get; set; }
        public string OldProviderName { get; set; }
        public int? OldProivderDataId { get; set; }
        public string UploadedProviderNameOld { get; set; }
        public string UploadedProviderNameNew { get; set; }
        public int? HoldedProviderIdOld { get; set; }
        public int? HoldedProviderIdNew { get; set; }
    }
}
