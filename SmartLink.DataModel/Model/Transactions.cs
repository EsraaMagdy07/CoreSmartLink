using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Transactions
    {
        public long Id { get; set; }
        public int? ActionFk { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateTime { get; set; }
        public int? ObjectSqlId { get; set; }
        public string SchemaName { get; set; }
        public string ProcName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public long? RowId { get; set; }

        public virtual Action ActionFkNavigation { get; set; }
    }
}
