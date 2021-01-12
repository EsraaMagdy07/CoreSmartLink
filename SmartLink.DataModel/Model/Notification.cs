using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Notification
    {
        public Notification()
        {
            UserNotificationRel = new HashSet<UserNotificationRel>();
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string Cced { get; set; }
        public int? AdminId { get; set; }
        public int? NotificationTemplateId { get; set; }
        public DateTime? InsertionDateTime { get; set; }
        public DateTime? SendingDateTime { get; set; }
        public int? NotificationTypeId { get; set; }
        public string AttachedFilePath { get; set; }

        public virtual Login Admin { get; set; }
        public virtual NotificationTemplate NotificationTemplate { get; set; }
        public virtual ICollection<UserNotificationRel> UserNotificationRel { get; set; }
    }
}
