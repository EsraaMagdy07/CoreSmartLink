using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class TempUploadingContents
    {
        public int Id { get; set; }
        public string SingerEnglish { get; set; }
        public string SingerArabic { get; set; }
        public int? SingerId { get; set; }
        public string AlbumEnglish { get; set; }
        public string AlbumArabic { get; set; }
        public int? AlbumId { get; set; }
        public string ContentEnglish { get; set; }
        public string ContentArabic { get; set; }
        public int? ContentId { get; set; }
        public string ProviderEnglish { get; set; }
        public string ProviderArabic { get; set; }
        public int? ProviderId { get; set; }
        public string CategoryNationality { get; set; }
        public int? CategoryId { get; set; }
        public string Notes { get; set; }
        public double? Show { get; set; }
        public string Countries { get; set; }
        public string CountriesIds { get; set; }
        public string Operators { get; set; }
        public string OperatorIds { get; set; }
        public string Services { get; set; }
        public string ServicesIds { get; set; }
        public string Exclusive { get; set; }
        public int? ExclusiveId { get; set; }
        public int? Uctid { get; set; }
        public DateTime? UploadingDateTime { get; set; }
    }
}
