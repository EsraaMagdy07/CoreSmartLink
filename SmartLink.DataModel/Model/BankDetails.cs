using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class BankDetails
    {
        public int Id { get; set; }
        public int? ProviderFk { get; set; }
        public string AccountNumber { get; set; }
        public string BeneficiaryName { get; set; }
        public string BeneficiaryAddress { get; set; }
        public string BeneficiaryBankName { get; set; }
        public string BeneficiaryBankAddress { get; set; }
        public string Iban { get; set; }
        public string SwiftCode { get; set; }
        public int? CountryFk { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
