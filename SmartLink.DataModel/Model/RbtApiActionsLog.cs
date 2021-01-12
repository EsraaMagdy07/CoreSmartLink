using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class RbtApiActionsLog
    {
        public int Id { get; set; }
        public string RequestLog { get; set; }
        public DateTime? InsertionDate { get; set; }
        public int? RbtApiActionId { get; set; }

        public virtual RbtApiActions RbtApiAction { get; set; }
    }
}
