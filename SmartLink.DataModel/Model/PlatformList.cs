using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformList
    {
        public PlatformList()
        {
            DailySummerization = new HashSet<DailySummerization>();
            DailyTemplate = new HashSet<DailyTemplate>();
            MetaDataTemplate = new HashSet<MetaDataTemplate>();
            MonthlyHitsEstimated = new HashSet<MonthlyHitsEstimated>();
            PlatformDailyRevUploaderLog = new HashSet<PlatformDailyRevUploaderLog>();
            PlatformData = new HashSet<PlatformData>();
            PlatformListDefaultValues = new HashSet<PlatformListDefaultValues>();
            PlatformListNotification = new HashSet<PlatformListNotification>();
            PlatformRevFileEmailConfiguration = new HashSet<PlatformRevFileEmailConfiguration>();
            PlatformRevFileFtpConfiguration = new HashSet<PlatformRevFileFtpConfiguration>();
            PlatformsOperatorsRel = new HashSet<PlatformsOperatorsRel>();
            PlatformsProvidersRel = new HashSet<PlatformsProvidersRel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public int? PlatformDistributerId { get; set; }
        public int? TerritoryId { get; set; }
        public bool? Daily { get; set; }
        public bool? Monthly { get; set; }
        public string GraphColor { get; set; }
        public int? PlatformTypeId { get; set; }
        public bool? IsGrouped { get; set; }
        public bool? IsIntegrated { get; set; }
        public bool? Displayed { get; set; }
        public int? DailyReportUploaderTypeId { get; set; }
        public bool? ToneCodeDefinition { get; set; }
        public bool? ToneNameDefinition { get; set; }
        public bool? ArtistNameDefinition { get; set; }

        public virtual PlatformReportUploaderType DailyReportUploaderType { get; set; }
        public virtual PlatformDistributor PlatformDistributer { get; set; }
        public virtual PlatformType PlatformType { get; set; }
        public virtual ICollection<DailySummerization> DailySummerization { get; set; }
        public virtual ICollection<DailyTemplate> DailyTemplate { get; set; }
        public virtual ICollection<MetaDataTemplate> MetaDataTemplate { get; set; }
        public virtual ICollection<MonthlyHitsEstimated> MonthlyHitsEstimated { get; set; }
        public virtual ICollection<PlatformDailyRevUploaderLog> PlatformDailyRevUploaderLog { get; set; }
        public virtual ICollection<PlatformData> PlatformData { get; set; }
        public virtual ICollection<PlatformListDefaultValues> PlatformListDefaultValues { get; set; }
        public virtual ICollection<PlatformListNotification> PlatformListNotification { get; set; }
        public virtual ICollection<PlatformRevFileEmailConfiguration> PlatformRevFileEmailConfiguration { get; set; }
        public virtual ICollection<PlatformRevFileFtpConfiguration> PlatformRevFileFtpConfiguration { get; set; }
        public virtual ICollection<PlatformsOperatorsRel> PlatformsOperatorsRel { get; set; }
        public virtual ICollection<PlatformsProvidersRel> PlatformsProvidersRel { get; set; }
    }
}
