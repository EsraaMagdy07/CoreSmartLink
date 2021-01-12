using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProviderDataLogs
    {
        public long Id { get; set; }
        public int OrgId { get; set; }
        public int StartMonth { get; set; }
        public int? StartYear { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public int? ProviderId { get; set; }
        public int? PaymentTypeId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RevenueShare { get; set; }
        public int? CurrencyId { get; set; }
        public bool? Exclusivity { get; set; }
        public string Countries { get; set; }
        public string Channels { get; set; }
        public bool? AllowToUpdate { get; set; }
        public bool? AllowToDelete { get; set; }
        public int? NotificationDays { get; set; }
        public bool? SendEmail { get; set; }
        public bool? ReqToUpdate { get; set; }
        public bool? ReqToDelete { get; set; }
        public bool? Checked { get; set; }
        public bool? Expired { get; set; }
        public bool? AutoRenewal { get; set; }
        public int? ContractId { get; set; }
        public int? AnnexId { get; set; }
        public int? DocId { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool? IsAnnex { get; set; }
        public bool? IsMuziCupContract { get; set; }
    }
}
