using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsTerritory
    {
        public CmsTerritory()
        {
            CmsOperator = new HashSet<CmsOperator>();
            CmsProviderContentTerritoryRel = new HashSet<CmsProviderContentTerritoryRel>();
        }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual ICollection<CmsOperator> CmsOperator { get; set; }
        public virtual ICollection<CmsProviderContentTerritoryRel> CmsProviderContentTerritoryRel { get; set; }
    }
}
