using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsProvider
    {
        public CmsProvider()
        {
            CmsProviderContantRel = new HashSet<CmsProviderContantRel>();
        }

        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }
        public int? ProviderContractId { get; set; }

        public virtual ICollection<CmsProviderContantRel> CmsProviderContantRel { get; set; }
    }
}
