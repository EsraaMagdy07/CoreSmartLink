using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class RegistrationStatus
    {
        public RegistrationStatus()
        {
            StatusTransactions = new HashSet<StatusTransactions>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public byte? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<StatusTransactions> StatusTransactions { get; set; }
    }
}
