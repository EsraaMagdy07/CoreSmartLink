using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class SitePermissions
    {
        public SitePermissions()
        {
            AccessMatrix = new HashSet<AccessMatrix>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AccessMatrix> AccessMatrix { get; set; }
    }
}
