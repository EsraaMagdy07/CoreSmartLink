using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AdvancePaymentsDocument
    {
        public int Id { get; set; }
        public int? MonthDate { get; set; }
        public int? YearDate { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int? ProviderContractId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? DocId { get; set; }
        public int? UserId { get; set; }
        public bool? IsMuzicUpPayment { get; set; }
        public DateTime? UploadedDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
