using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class NewsLetterSubscription
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime? InsertionDtm { get; set; }
    }
}
