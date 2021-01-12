using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CurrencyConverterLog
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public int CurrencyIdFrom { get; set; }
        public int CurrencyIdTo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal? BudgetRate { get; set; }
    }
}
