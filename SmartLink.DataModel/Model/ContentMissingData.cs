using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ContentMissingData
    {
        public int Id { get; set; }
        public int? PlatformListId { get; set; }
        public string ToneCode { get; set; }
        public string ToneName { get; set; }
        public string ArtistName { get; set; }
        public string ProviderName { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}
