using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class SiteControllers
    {
        public SiteControllers()
        {
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
