using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Documentation
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public int? ParentDocId { get; set; }
        public string SerialNumber { get; set; }
        public int? DocType { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }

        public virtual DocumentType ParentDoc { get; set; }
    }
}
