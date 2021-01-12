using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ColumnType
    {
        public ColumnType()
        {
            DailyTemplateColumns = new HashSet<DailyTemplateColumns>();
        }

        public int Id { get; set; }
        public string ColumnType1 { get; set; }

        public virtual ICollection<DailyTemplateColumns> DailyTemplateColumns { get; set; }
    }
}
