using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
