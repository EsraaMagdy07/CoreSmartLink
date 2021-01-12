using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class YouTubeReportsMusic
    {
        public int Id { get; set; }
        public string AdjustmentType { get; set; }
        public string AssetId { get; set; }
        public string AssetTitle { get; set; }
        public string AssetLabels { get; set; }
        public string AssetChannelId { get; set; }
        public string AssetType { get; set; }
        public string CustomId { get; set; }
        public string Isrc { get; set; }
        public string Upc { get; set; }
        public string Grid { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Label { get; set; }
        public string AdministerPublishRights { get; set; }
        public string OwnedViews { get; set; }
        public string YouTubeRevenueSplitAuction { get; set; }
        public string YouTubeRevenueSplitReserved { get; set; }
        public string YouTubeRevenueSplitPartnerSoldYouTubeServed { get; set; }
        public string YouTubeRevenueSplitPartnerSoldPartnerServed { get; set; }
        public string YouTubeRevenueSplit { get; set; }
        public string PartnerRevenueAuction { get; set; }
        public string PartnerRevenueReserved { get; set; }
        public string PartnerRevenuePartnerSoldYouTubeServed { get; set; }
        public string PartnerRevenuePartnerSoldPartnerServed { get; set; }
        public string PartnerRevenue { get; set; }
    }
}
