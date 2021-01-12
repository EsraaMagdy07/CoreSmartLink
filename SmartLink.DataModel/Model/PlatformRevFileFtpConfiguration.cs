using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformRevFileFtpConfiguration
    {
        public int Id { get; set; }
        public int? PlatformId { get; set; }
        public string FtpUrl { get; set; }
        public string FtpUserName { get; set; }
        public string FtpPassword { get; set; }
        public string FileName { get; set; }
        public bool? IsDaily { get; set; }
        public bool? IsMonthly { get; set; }
        public TimeSpan? DeliveryDate { get; set; }
        public string SheetName { get; set; }
        public bool? IsMetaData { get; set; }
        public bool? IsContractId { get; set; }
        public string ProviderSheetInfo { get; set; }
        public bool? IsProviderInfo { get; set; }
        public int? TemplateId { get; set; }

        public virtual PlatformList Platform { get; set; }
    }
}
