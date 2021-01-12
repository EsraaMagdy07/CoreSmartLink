using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProvidersUploadedRbtNamesHolded
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string Name { get; set; }
        public DateTime? InsertDateTime { get; set; }

        public virtual ProviderList Provider { get; set; }
    }
}
