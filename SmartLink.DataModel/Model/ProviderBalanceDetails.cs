using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProviderBalanceDetails
    {
        public int Id { get; set; }
        public int? ProviderBalanceId { get; set; }
        public DateTime? BalanceDate { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? ProviderContractId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? PlatformId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? LocalBalance { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }
        public bool? IsAutomated { get; set; }
        public bool? IsPaid { get; set; }

        public virtual ProviderBalance ProviderBalance { get; set; }
    }
}
