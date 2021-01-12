using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AdvanceMonthlyPaymentsSmsLogs
    {
        public long Id { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? SendDateTime { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderLegalId { get; set; }
        public int? YearDate { get; set; }
        public int? MonthDate { get; set; }
        public int? UserId { get; set; }
        public DateTime? StartingDate { get; set; }
    }
}
