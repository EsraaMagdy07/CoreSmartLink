using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class MetaDataTemplate
    {
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public int? PlatformId { get; set; }
        public int? BasicColumnId { get; set; }
        public bool? IsMandatery { get; set; }
        public bool? IsFilterColumn { get; set; }
        public string FilteredValue { get; set; }
        public int? OrderNumber { get; set; }
        public bool? IsExcept { get; set; }

        public virtual MetaDataBasicColumns BasicColumn { get; set; }
        public virtual PlatformList Platform { get; set; }
    }
}
