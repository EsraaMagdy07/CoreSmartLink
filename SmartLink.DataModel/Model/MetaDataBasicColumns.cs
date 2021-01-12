using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class MetaDataBasicColumns
    {
        public MetaDataBasicColumns()
        {
            MetaDataTemplate = new HashSet<MetaDataTemplate>();
        }

        public int Id { get; set; }
        public string ColumnName { get; set; }

        public virtual ICollection<MetaDataTemplate> MetaDataTemplate { get; set; }
    }
}
