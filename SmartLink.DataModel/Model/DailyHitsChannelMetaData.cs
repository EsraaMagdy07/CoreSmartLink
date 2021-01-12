using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class DailyHitsChannelMetaData
    {
        public int Id { get; set; }
        public DateTime? DayDate { get; set; }
        public int? DailyHitsId { get; set; }
        public string ToneCode { get; set; }
        public int? PlatformId { get; set; }
        public int? ProviderId { get; set; }
        public int? ProviderDataId { get; set; }
        public string AssetType { get; set; }
        public int? Likes { get; set; }
        public decimal? Shares { get; set; }
        public string Comments { get; set; }
        public int? VideosInPlaylists { get; set; }
        public int? WatchTimeMinutes { get; set; }
        public int? Views { get; set; }
        public decimal? AverageViewMinutes { get; set; }
        public DateTime InsertionDateTime { get; set; }
        public int? UserId { get; set; }

        public virtual DailyHits DailyHits { get; set; }
    }
}
