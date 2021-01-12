using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class DataShifting
    {
        public int Id { get; set; }
        public int? ReqId { get; set; }
        public DateTime? InsertionDatetime { get; set; }
        public int? UserId { get; set; }
        public int? SuperUserId { get; set; }
        public string ApproveStatus { get; set; }
        public DateTime? ApprovedDatetime { get; set; }
        public bool? ShiftingIsDone { get; set; }
        public DateTime? ShiftingDateTime { get; set; }
        public string Comment { get; set; }
    }
}
