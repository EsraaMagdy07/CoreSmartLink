using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ContractType
    {
        public ContractType()
        {
            AccountManager = new HashSet<AccountManager>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<AccountManager> AccountManager { get; set; }
    }
}
