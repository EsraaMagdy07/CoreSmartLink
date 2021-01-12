using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int ControllerId { get; set; }
        public int? LoginId { get; set; }

        public virtual SiteControllers Controller { get; set; }
        public virtual Login Login { get; set; }
        public virtual Users User { get; set; }
    }
}
