using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class DailyTemplateColumns
    {
        public DailyTemplateColumns()
        {
            TemplateColumnFilterValues = new HashSet<TemplateColumnFilterValues>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsMandatory { get; set; }
        public int? OrderNumber { get; set; }
        public int? TemplateId { get; set; }
        public bool? IsCalculated { get; set; }
        public int? ColumnTypeId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsFiltered { get; set; }

        public virtual ColumnType ColumnType { get; set; }
        public virtual DailyTemplate Template { get; set; }
        public virtual ICollection<TemplateColumnFilterValues> TemplateColumnFilterValues { get; set; }
    }
}
