using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UserNotificationRel
    {
        public int Id { get; set; }
        public int? NotificationId { get; set; }
        public int? UserRecieveId { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? SendingDateTime { get; set; }
        public string AlternativeRecipient { get; set; }
        public bool? IsSent { get; set; }
        public int? AdminRecieveId { get; set; }

        public virtual Login AdminRecieve { get; set; }
        public virtual Notification Notification { get; set; }
        public virtual Users UserRecieve { get; set; }
    }
}
