using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformListDefaultValues
    {
        public int Id { get; set; }
        public int? PlatformId { get; set; }
        public string ArtistNameDefault { get; set; }

        public virtual PlatformList Platform { get; set; }
    }
}
