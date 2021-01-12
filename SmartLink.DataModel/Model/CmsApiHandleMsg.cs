using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsApiHandleMsg
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Status { get; set; }
        public int? StatusCode { get; set; }
        public string MsgDetails { get; set; }
        public DateTime? InsertionDate { get; set; }
    }
}
