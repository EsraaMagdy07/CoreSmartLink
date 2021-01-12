using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsProviderContentOperatorRel
    {
        public int Id { get; set; }
        public int? CmsProviderContentRelId { get; set; }
        public int? CmsOperatorId { get; set; }
        public bool? Excluded { get; set; }
        public int? Uctid { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }

        public virtual CmsProviderContantRel CmsProviderContentRel { get; set; }
    }
}
