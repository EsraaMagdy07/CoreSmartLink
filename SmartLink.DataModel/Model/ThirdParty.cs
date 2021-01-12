using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ThirdParty
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public DateTime StartOfContract { get; set; }
        public DateTime EndOfContract { get; set; }
        public string ThirdUserName { get; set; }
        public string ThirdPassword { get; set; }
        public string CompanyPrefix { get; set; }
        public bool? Isexpired { get; set; }
        public int? Notificationperiod { get; set; }
        public short? EditedBy { get; set; }
        public DateTime? EditingDatetime { get; set; }
        public bool? IsContentProvider { get; set; }
    }
}
