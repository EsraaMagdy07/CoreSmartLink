using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProvidersUsers
    {
        public int ProviderId { get; set; }
        public int? UserId { get; set; }
        public int? MuzicUpProviderId { get; set; }
        public DateTime? InsertationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
