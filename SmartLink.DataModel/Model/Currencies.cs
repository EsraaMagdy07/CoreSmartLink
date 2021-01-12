using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Currencies
    {
        public Currencies()
        {
            AccountManagerMonthlyTarget = new HashSet<AccountManagerMonthlyTarget>();
            CurrencyConverterCurrencyIdFromNavigation = new HashSet<CurrencyConverter>();
            CurrencyConverterCurrencyIdToNavigation = new HashSet<CurrencyConverter>();
        }

        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public DateTime? InsertationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ICollection<AccountManagerMonthlyTarget> AccountManagerMonthlyTarget { get; set; }
        public virtual ICollection<CurrencyConverter> CurrencyConverterCurrencyIdFromNavigation { get; set; }
        public virtual ICollection<CurrencyConverter> CurrencyConverterCurrencyIdToNavigation { get; set; }
    }
}
