using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class DailyTemplate
    {
        public DailyTemplate()
        {
            DailyTemplateColumns = new HashSet<DailyTemplateColumns>();
        }

        public int Id { get; set; }
        public int? PlatformId { get; set; }
        public string FileName { get; set; }
        public string PlatformNameInExcel { get; set; }

        public virtual PlatformList Platform { get; set; }
        public virtual ICollection<DailyTemplateColumns> DailyTemplateColumns { get; set; }
    }
}
