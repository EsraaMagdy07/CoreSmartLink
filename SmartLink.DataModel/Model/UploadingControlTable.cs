using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UploadingControlTable
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime? RunningDateTime { get; set; }
        public int? UploadedContentsCount { get; set; }
        public bool? OperationStatus { get; set; }
        public string Description { get; set; }
    }
}
