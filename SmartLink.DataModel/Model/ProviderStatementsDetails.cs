using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProviderStatementsDetails
    {
        public long Id { get; set; }
        public long? StatementId { get; set; }
        public int? YearDate { get; set; }
        public int? MonthDate { get; set; }
        public DateTime? DateValue { get; set; }
        public int? ProviderContractId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? PlatformId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? OperatorAmount { get; set; }
        public decimal? OutStBalanceAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? PaidAdvance { get; set; }
        public decimal? PaidOutStBalance { get; set; }
        public decimal? PaidContractAmount { get; set; }
        public decimal? TotalPaidAmount { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public bool? IsPaid { get; set; }
        public DateTime? PaidDateTime { get; set; }
        public bool? IsConfirmed { get; set; }
        public DateTime? ConfirmedDateTime { get; set; }
        public bool? IsOutStandingBalance { get; set; }

        public virtual ProviderStatements Statement { get; set; }
    }
}
