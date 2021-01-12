using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class RegistrationAdmins
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
