using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsOperator
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string SheetMapper { get; set; }
        public int? TerritoryId { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual CmsTerritory Territory { get; set; }
    }
}
