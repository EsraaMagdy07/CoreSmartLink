using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformListNotificationLogs
    {
        public int Id { get; set; }
        public int? PlatformNotificationId { get; set; }
        public DateTime? SendingDateTime { get; set; }
        public DateTime? InsertionDateTime { get; set; }

        public virtual PlatformListNotification PlatformNotification { get; set; }
    }
}
