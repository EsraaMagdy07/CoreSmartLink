using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CurrencyConverter
    {
        public int Id { get; set; }
        public int CurrencyIdFrom { get; set; }
        public int CurrencyIdTo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal? BudgetRate { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? InsertionDateTime { get; set; }

        public virtual Currencies CurrencyIdFromNavigation { get; set; }
        public virtual Currencies CurrencyIdToNavigation { get; set; }
    }
}
