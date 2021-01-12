using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformsProvidersRel
    {
        public int Id { get; set; }
        public int? PlatformId { get; set; }
        public int? ProviderId { get; set; }
        public string Name { get; set; }

        public virtual PlatformList Platform { get; set; }
        public virtual ProviderList Provider { get; set; }
    }
}
