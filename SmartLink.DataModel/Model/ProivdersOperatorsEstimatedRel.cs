using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProivdersOperatorsEstimatedRel
    {
        public int Id { get; set; }
        public int? ProviderListId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? OperatorId { get; set; }
        public int? DocFk { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual RbtOperators Operator { get; set; }
        public virtual ProviderData ProviderData { get; set; }
    }
}
