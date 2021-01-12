using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ContentsData
    {
        public long Id { get; set; }
        public int? PlatformId { get; set; }
        public DateTime Date { get; set; }
        public string Cmscode { get; set; }
        public string AlbumNameAr { get; set; }
        public string AlbumName { get; set; }
        public string ArtistNameAr { get; set; }
        public string ArtistName { get; set; }
        public string ToneNameAr { get; set; }
        public string ToneName { get; set; }
        public string ToneCode { get; set; }
        public string ProviderName { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public double? Price { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public string LiveCode { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public string Isrc { get; set; }
        public string Uid { get; set; }
        public bool? IsLocal { get; set; }
        public int? DocId { get; set; }
        public string Url { get; set; }
    }
}
