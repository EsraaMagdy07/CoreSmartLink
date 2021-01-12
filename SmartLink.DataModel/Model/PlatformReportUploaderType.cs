using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformReportUploaderType
    {
        public PlatformReportUploaderType()
        {
            PlatformList = new HashSet<PlatformList>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<PlatformList> PlatformList { get; set; }
    }
}
