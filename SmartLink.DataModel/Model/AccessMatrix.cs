using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AccessMatrix
    {
        public int Id { get; set; }
        public int? UserFk { get; set; }
        public int? RegionFk { get; set; }
        public int? PermissionLevel { get; set; }

        public virtual SitePermissions PermissionLevelNavigation { get; set; }
    }
}
