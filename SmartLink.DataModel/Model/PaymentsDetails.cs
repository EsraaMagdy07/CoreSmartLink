using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PaymentsDetails
    {
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public int? CurrencyFk { get; set; }
        public int? PaymentTypeFk { get; set; }
        public int? ProviderId { get; set; }
        public int? ProviderDataId { get; set; }
        public int? ContractId { get; set; }
        public int? AnnexId { get; set; }
        public int? DocFk { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
