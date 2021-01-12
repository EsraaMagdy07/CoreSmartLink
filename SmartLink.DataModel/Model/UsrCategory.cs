using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UsrCategory
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
