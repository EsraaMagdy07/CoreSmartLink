using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Providers
    {
        public Providers()
        {
            AccountManager = new HashSet<AccountManager>();
            MonthlyHitsEstimated = new HashSet<MonthlyHitsEstimated>();
            ProviderList = new HashSet<ProviderList>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CommercialName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccountNumber { get; set; }
        public double? MonthlyAdvanceShare { get; set; }
        public bool? MonthlyPayments { get; set; }
        public bool? ViewReports { get; set; }
        public int? CurrencyId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public string PersonalEmail { get; set; }
        public string PersonalPhone { get; set; }
        public bool? Invoicing { get; set; }
        public string InvoiceDescription { get; set; }
        public DateTime? InvoicingModificationDatetime { get; set; }
        public int? InvoicingModificationLoginId { get; set; }
        public bool? IsTop { get; set; }

        public virtual ProvidersMuzicUp ProvidersMuzicUp { get; set; }
        public virtual ICollection<AccountManager> AccountManager { get; set; }
        public virtual ICollection<MonthlyHitsEstimated> MonthlyHitsEstimated { get; set; }
        public virtual ICollection<ProviderList> ProviderList { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
