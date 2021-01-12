using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class RbtApiActions
    {
        public RbtApiActions()
        {
            RbtApiActionsLog = new HashSet<RbtApiActionsLog>();
        }

        public int Id { get; set; }
        public string Action { get; set; }

        public virtual ICollection<RbtApiActionsLog> RbtApiActionsLog { get; set; }
    }
}
