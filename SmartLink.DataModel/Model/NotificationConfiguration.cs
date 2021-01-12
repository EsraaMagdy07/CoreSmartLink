using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class NotificationConfiguration
    {
        public NotificationConfiguration()
        {
            NotificationType = new HashSet<NotificationType>();
        }

        public int Id { get; set; }
        public string Host { get; set; }
        public short? Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<NotificationType> NotificationType { get; set; }
    }
}
