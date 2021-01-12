using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformDailyRevUploaderLog
    {
        public int Id { get; set; }
        public int? PlatformId { get; set; }
        public string DownloadedFileName { get; set; }
        public DateTime? RunDateTime { get; set; }
        public DateTime? FileLastModificationDate { get; set; }
        public bool? IsDone { get; set; }
        public int? TotalRecordsCount { get; set; }
        public int? RecordsSuccessCount { get; set; }
        public int? RecordsFailedCount { get; set; }
        public int? RecordsWithEmptyCellsCount { get; set; }
        public int? RecordsUploadedBeforCount { get; set; }
        public int? RecordsWithInvalidFormatCount { get; set; }
        public string ErrorMessage { get; set; }
        public decimal? TotalRevenue { get; set; }
        public bool? IsDaily { get; set; }
        public bool? IsMonthly { get; set; }
        public string DaysInSheet { get; set; }
        public int? TemplateId { get; set; }

        public virtual PlatformList Platform { get; set; }
    }
}
