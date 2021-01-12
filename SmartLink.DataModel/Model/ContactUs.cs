using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ContactUs
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
