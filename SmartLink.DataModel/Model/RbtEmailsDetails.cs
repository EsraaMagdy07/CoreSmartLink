using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class RbtEmailsDetails
    {
        public int Id { get; set; }
        public int? YearDate { get; set; }
        public int? MonthDate { get; set; }
        public int? PlatformId { get; set; }
        public int? OldProviderId { get; set; }
        public int? OldProviderDataId { get; set; }
        public int? NewProviderId { get; set; }
        public int? NewProviderDataId { get; set; }
        public string OldProviderName { get; set; }
        public string NewProviderName { get; set; }
        public DateTime? SendDateTime { get; set; }
        public int? RequestTypeId { get; set; }
        public string SendTo { get; set; }
        public string SendCc { get; set; }
        public bool? Accepted { get; set; }
        public DateTime? AcceptedDateTime { get; set; }
        public bool? Executed { get; set; }
        public DateTime? ExecutionDateTime { get; set; }
        public int? ContentUserId { get; set; }
        public string ContentUserName { get; set; }
        public int? FinancialUserId { get; set; }
        public string FinancialUserName { get; set; }
        public string SelectedIds { get; set; }
        public int? SelectedProviderId { get; set; }
        public int? SelectedProviderDataId { get; set; }
    }
}
