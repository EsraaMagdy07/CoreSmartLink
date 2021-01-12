using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformListNotification
    {
        public PlatformListNotification()
        {
            PlatformListNotificationLogs = new HashSet<PlatformListNotificationLogs>();
        }

        public int Id { get; set; }
        public int? PlatformListId { get; set; }
        public int? NotificationType { get; set; }
        public int? NoticePeriod { get; set; }
        public int? NotificationTemplateId { get; set; }

        public virtual NotificationTemplate NotificationTemplate { get; set; }
        public virtual NotificationType NotificationTypeNavigation { get; set; }
        public virtual PlatformList PlatformList { get; set; }
        public virtual ICollection<PlatformListNotificationLogs> PlatformListNotificationLogs { get; set; }
    }
}
