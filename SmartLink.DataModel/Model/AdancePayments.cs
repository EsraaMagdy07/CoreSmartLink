using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AdancePayments
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public int? ProviderContractId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? PlatformId { get; set; }
        public int? CurrencyId { get; set; }
        public double? ContractShare { get; set; }
        public double? Share { get; set; }
        public decimal? TotalAmountLocal { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? AmountLocal { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public bool? Rejected { get; set; }
        public bool? AllowToModify { get; set; }
        public bool? Paid { get; set; }
        public DateTime? PaidDateTime { get; set; }
        public int? UserId { get; set; }
    }
}
