using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProviderBalance
    {
        public ProviderBalance()
        {
            ProviderBalanceDetails = new HashSet<ProviderBalanceDetails>();
        }

        public int Id { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? ProviderContractId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public DateTime? MonthDate { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public bool? IsAutomated { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }
        public bool? IsOutStandingBalance { get; set; }

        public virtual ICollection<ProviderBalanceDetails> ProviderBalanceDetails { get; set; }
    }
}
