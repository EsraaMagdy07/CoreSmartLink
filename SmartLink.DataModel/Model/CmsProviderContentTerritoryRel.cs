using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsProviderContentTerritoryRel
    {
        public int Id { get; set; }
        public int? CmsProviderContentRelId { get; set; }
        public int? CmsTerritoryId { get; set; }
        public bool? Excluded { get; set; }
        public int? Uctid { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }

        public virtual CmsProviderContantRel CmsProviderContentRel { get; set; }
        public virtual CmsTerritory CmsTerritory { get; set; }
    }
}
