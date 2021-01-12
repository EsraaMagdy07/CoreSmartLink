using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class MonthlyHitsEstimated
    {
        public int Id { get; set; }
        public int? YearDate { get; set; }
        public int? MonthDate { get; set; }
        public int? PlatformId { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public decimal? Revenue { get; set; }
        public int? UserId { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public bool? AllowToUpdate { get; set; }
        public string Notes { get; set; }
        public bool? Collected { get; set; }
        public bool? Paid { get; set; }
        public bool? Released { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Gm { get; set; }

        public virtual PlatformList Platform { get; set; }
        public virtual Providers Provider { get; set; }
        public virtual ProviderData ProviderData { get; set; }
        public virtual ProviderList ProviderList { get; set; }
        public virtual Login User { get; set; }
    }
}
