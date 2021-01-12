using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AdvancePaymentsContracts
    {
        public int Id { get; set; }
        public int? ProviderContractId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PaymentTypeId { get; set; }
        public decimal? AmountLocal { get; set; }
        public int? CurrencyIdLocal { get; set; }
        public decimal? Amount { get; set; }
        public decimal? CurrencyRate { get; set; }
        public int? ProviderCurrencyId { get; set; }
        public DateTime? InsertionDatetime { get; set; }
        public DateTime? ModificationDatetime { get; set; }
        public bool? Paid { get; set; }
        public DateTime? PaidDate { get; set; }
        public DateTime? PaidActionDateTime { get; set; }
        public int? UserId { get; set; }
        public bool? IsGrace { get; set; }
        public int? ContractMonths { get; set; }
        public int? GraceMonths { get; set; }
        public bool? AutoRenewal { get; set; }
        public bool? IsExpired { get; set; }
        public bool? IsAutomated { get; set; }
        public string Description { get; set; }
        public int? AdvancePaymentsDocumentId { get; set; }
        public bool? BreakEvenPoint { get; set; }
        public int? GraceMonthsBeforeBe { get; set; }
        public DateTime? BeEndDate { get; set; }
    }
}
