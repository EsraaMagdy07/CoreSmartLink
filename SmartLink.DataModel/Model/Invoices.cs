using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Invoices
    {
        public Invoices()
        {
            InvoicesDetails = new HashSet<InvoicesDetails>();
        }

        public int Id { get; set; }
        public int? Number { get; set; }
        public string CpNumber { get; set; }
        public int? BranchId { get; set; }
        public int? StatusId { get; set; }
        public int? ProviderContractId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? DocId { get; set; }
        public int? IssueYear { get; set; }
        public int? IssueMonth { get; set; }
        public DateTime? IssueDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalAdvance { get; set; }
        public int? CurrecnyId { get; set; }
        public string Remarks { get; set; }
        public int? InvoiceDocId { get; set; }
        public DateTime? UploadDateTime { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public int? UserId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime? ModifiedByUser { get; set; }
        public DateTime? ModifiedByCp { get; set; }

        public virtual InvoiceStatus Status { get; set; }
        public virtual ICollection<InvoicesDetails> InvoicesDetails { get; set; }
    }
}
