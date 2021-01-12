using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProviderData
    {
        public ProviderData()
        {
            AccountManager = new HashSet<AccountManager>();
            MonthlyHitsEstimated = new HashSet<MonthlyHitsEstimated>();
            ProivdersOperatorsEstimatedRel = new HashSet<ProivdersOperatorsEstimatedRel>();
            ProivdersOperatorsRel = new HashSet<ProivdersOperatorsRel>();
        }

        public int Id { get; set; }
        public int? StartMonth { get; set; }
        public int? StartYear { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CostStartDate { get; set; }
        public DateTime? CostEndDate { get; set; }
        public int? GraceMonths { get; set; }
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
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public bool? IsAnnex { get; set; }
        public bool? IsMuziCupContract { get; set; }
        public bool? IsArchived { get; set; }

        public virtual ProviderList Provider { get; set; }
        public virtual ICollection<AccountManager> AccountManager { get; set; }
        public virtual ICollection<MonthlyHitsEstimated> MonthlyHitsEstimated { get; set; }
        public virtual ICollection<ProivdersOperatorsEstimatedRel> ProivdersOperatorsEstimatedRel { get; set; }
        public virtual ICollection<ProivdersOperatorsRel> ProivdersOperatorsRel { get; set; }
    }
}
