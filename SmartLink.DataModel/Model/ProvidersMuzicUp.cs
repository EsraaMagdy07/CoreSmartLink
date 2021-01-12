using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProvidersMuzicUp
    {
        public int Id { get; set; }
        public int? ProvidersId { get; set; }
        public bool? PaymentIssue { get; set; }
        public string Description { get; set; }
        public DateTime? InsterationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? LoginId { get; set; }

        public virtual Login Login { get; set; }
        public virtual Providers Providers { get; set; }
    }
}
