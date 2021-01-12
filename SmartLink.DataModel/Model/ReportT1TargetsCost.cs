using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ReportT1TargetsCost
    {
        public int Id { get; set; }
        public int? PlatformTypeId { get; set; }
        public int? ContractId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public DateTime? Date { get; set; }
        public int? YearDate { get; set; }
        public int? MonthDate { get; set; }
        public decimal? TotalRevenue { get; set; }
        public decimal? RevenueMonth { get; set; }
        public decimal? RevenueYear { get; set; }
        public decimal? RevenuePerContract { get; set; }
        public decimal? CostMonthShare { get; set; }
        public decimal? CostMonthAdv { get; set; }
        public decimal? CostMonth { get; set; }
        public decimal? CostYearShare { get; set; }
        public decimal? CostYearAdv { get; set; }
        public decimal? CostYear { get; set; }
        public decimal? CostPerContractShare { get; set; }
        public decimal? CostPerContractAdv { get; set; }
        public decimal? CostPerContract { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}
