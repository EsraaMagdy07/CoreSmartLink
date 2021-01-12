using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsProviderContentContentTypeRel
    {
        public int Id { get; set; }
        public int? CmsProviderContentRelId { get; set; }
        public int? CmsContentTypeId { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual CmsContentType CmsContentType { get; set; }
        public virtual CmsProviderContantRel CmsProviderContentRel { get; set; }
    }
}
