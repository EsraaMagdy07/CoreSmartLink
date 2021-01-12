using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ContractContentDataTemp
    {
        public int Id { get; set; }
        public int? DateYear { get; set; }
        public int? DateMonth { get; set; }
        public DateTime? DateDay { get; set; }
        public int? PlatformId { get; set; }
        public int? ProviderId { get; set; }
        public int? ProviderDataId { get; set; }
        public string ProviderName { get; set; }
        public int? HoldedProviderId { get; set; }
        public string UploadedProviderName { get; set; }
        public string ToneCode { get; set; }
        public string SingerName { get; set; }
        public string SongName { get; set; }
        public bool? IsDaily { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
