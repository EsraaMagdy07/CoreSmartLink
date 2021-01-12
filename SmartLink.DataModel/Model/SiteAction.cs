using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class SiteAction
    {
        public SiteAction()
        {
            LogEvent = new HashSet<LogEvent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LogEvent> LogEvent { get; set; }
    }
}
