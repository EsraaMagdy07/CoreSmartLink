using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AccountManager
    {
        public AccountManager()
        {
            AccountManagerMonthlyTarget = new HashSet<AccountManagerMonthlyTarget>();
        }

        public int Id { get; set; }
        public int? AccountId { get; set; }
        public int? ProviderId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? ContractTypeId { get; set; }
        public int? ChannelId { get; set; }
        public bool? BiMonthlyCalculation { get; set; }

        public virtual Login Account { get; set; }
        public virtual PlatformType Channel { get; set; }
        public virtual ContractType ContractType { get; set; }
        public virtual Providers Provider { get; set; }
        public virtual ProviderData ProviderData { get; set; }
        public virtual ProviderList ProviderList { get; set; }
        public virtual ICollection<AccountManagerMonthlyTarget> AccountManagerMonthlyTarget { get; set; }
    }
}
