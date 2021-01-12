using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsProviderContantRel
    {
        public CmsProviderContantRel()
        {
            CmsProviderContentChannelRel = new HashSet<CmsProviderContentChannelRel>();
            CmsProviderContentContentTypeRel = new HashSet<CmsProviderContentContentTypeRel>();
            CmsProviderContentOperatorRel = new HashSet<CmsProviderContentOperatorRel>();
            CmsProviderContentTerritoryRel = new HashSet<CmsProviderContentTerritoryRel>();
        }

        public int Id { get; set; }
        public int? CmsContentId { get; set; }
        public int? CmsProviderId { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? ProviderContractId { get; set; }
        public int? DocFk { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual CmsContent CmsContent { get; set; }
        public virtual CmsProvider CmsProvider { get; set; }
        public virtual ICollection<CmsProviderContentChannelRel> CmsProviderContentChannelRel { get; set; }
        public virtual ICollection<CmsProviderContentContentTypeRel> CmsProviderContentContentTypeRel { get; set; }
        public virtual ICollection<CmsProviderContentOperatorRel> CmsProviderContentOperatorRel { get; set; }
        public virtual ICollection<CmsProviderContentTerritoryRel> CmsProviderContentTerritoryRel { get; set; }
    }
}
