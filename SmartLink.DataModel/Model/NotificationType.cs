using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class NotificationType
    {
        public NotificationType()
        {
            NotificationTemplate = new HashSet<NotificationTemplate>();
            PlatformListNotification = new HashSet<PlatformListNotification>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public int? NotificationConfigId { get; set; }
        public string DisplayName { get; set; }

        public virtual NotificationConfiguration NotificationConfig { get; set; }
        public virtual ICollection<NotificationTemplate> NotificationTemplate { get; set; }
        public virtual ICollection<PlatformListNotification> PlatformListNotification { get; set; }
    }
}
