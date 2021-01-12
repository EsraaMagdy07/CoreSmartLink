using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class InvoicesDetails
    {
        public int Id { get; set; }
        public int? InvoiceId { get; set; }
        public int? ProviderContractId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public decimal? TotalAdvanceAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalRemainAmount { get; set; }
        public int? CurrencyId { get; set; }
        public int? DateYear { get; set; }
        public int? DateMonth { get; set; }
        public int PlatformId { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DetetedDateTime { get; set; }
        public bool? IsPaid { get; set; }
        public bool? IsConfirmed { get; set; }
        public int? UserId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ModifiedByUser { get; set; }
        public DateTime? ModifiedByCp { get; set; }

        public virtual Invoices Invoice { get; set; }
    }
}
