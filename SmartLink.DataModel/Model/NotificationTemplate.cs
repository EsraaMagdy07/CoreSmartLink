using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class NotificationTemplate
    {
        public NotificationTemplate()
        {
            Notification = new HashSet<Notification>();
            PlatformListNotification = new HashSet<PlatformListNotification>();
        }

        public int Id { get; set; }
        public int? AdminId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public string Bccs { get; set; }
        public string Ccs { get; set; }
        public string Params { get; set; }
        public int? NotificationTypeId { get; set; }
        public string To { get; set; }

        public virtual Login Admin { get; set; }
        public virtual NotificationType NotificationType { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual ICollection<PlatformListNotification> PlatformListNotification { get; set; }
    }
}
