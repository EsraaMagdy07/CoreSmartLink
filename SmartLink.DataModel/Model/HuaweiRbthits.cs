using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class HuaweiRbthits
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Cpname { get; set; }
        public double? RbthitsTotal { get; set; }
        public double? RbthitsTotalFee { get; set; }
        public int? EditedBy { get; set; }
        public DateTime? EditingDateTime { get; set; }
    }
}
