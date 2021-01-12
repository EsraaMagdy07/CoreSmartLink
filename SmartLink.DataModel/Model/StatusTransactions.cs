using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class StatusTransactions
    {
        public int Id { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public int? RegistrationStatusId { get; set; }
        public int? UserId { get; set; }
        public int? AccountManagerId { get; set; }
        public string Notes { get; set; }

        public virtual Login AccountManager { get; set; }
        public virtual RegistrationStatus RegistrationStatus { get; set; }
        public virtual Users User { get; set; }
    }
}
