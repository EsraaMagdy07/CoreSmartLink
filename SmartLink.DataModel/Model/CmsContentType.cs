using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsContentType
    {
        public CmsContentType()
        {
            CmsProviderContentContentTypeRel = new HashSet<CmsProviderContentContentTypeRel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CmsProviderContentContentTypeRel> CmsProviderContentContentTypeRel { get; set; }
    }
}
