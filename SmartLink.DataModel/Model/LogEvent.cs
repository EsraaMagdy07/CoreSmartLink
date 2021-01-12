using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class LogEvent
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string LogDescription { get; set; }
        public int ActionId { get; set; }
        public int ControllerId { get; set; }
        public DateTime? LogDate { get; set; }
        public int? UserId { get; set; }

        public virtual SiteAction Action { get; set; }
    }
}
