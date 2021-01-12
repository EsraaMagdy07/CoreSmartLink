using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class LoginPerCountry
    {
        public int Id { get; set; }
        public int? LoginId { get; set; }
        public int? CountryId { get; set; }

        public virtual Territory Country { get; set; }
        public virtual Login Login { get; set; }
    }
}
