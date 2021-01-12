using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AccountManagerMonthlyTarget
    {
        public int Id { get; set; }
        public int? AccountManagerId { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public decimal? RevTarget { get; set; }
        public decimal? GmTarget { get; set; }
        public int? CurrencyId { get; set; }

        public virtual AccountManager AccountManager { get; set; }
        public virtual Currencies Currency { get; set; }
    }
}
