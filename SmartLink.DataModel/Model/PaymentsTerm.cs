using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PaymentsTerm
    {
        public int Id { get; set; }
        public int? PaymentDetialsFk { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
        public int? ContractId { get; set; }
        public int? AnnexId { get; set; }
        public int? DocId { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
