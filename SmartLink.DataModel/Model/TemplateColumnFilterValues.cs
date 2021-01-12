using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class TemplateColumnFilterValues
    {
        public int Id { get; set; }
        public int? PlatformTemplateColumnId { get; set; }
        public string FilterValue { get; set; }
        public bool? IsContain { get; set; }

        public virtual DailyTemplateColumns PlatformTemplateColumn { get; set; }
    }
}
