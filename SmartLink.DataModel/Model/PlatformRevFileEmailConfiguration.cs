using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformRevFileEmailConfiguration
    {
        public int Id { get; set; }
        public string Host { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Port { get; set; }
        public string Subject { get; set; }
        public string Sender { get; set; }
        public string FileName { get; set; }
        public string SheetName { get; set; }
        public bool? IsDaily { get; set; }
        public bool? IsMonthly { get; set; }
        public int? PlatformId { get; set; }
        public int? TemplateId { get; set; }

        public virtual PlatformList Platform { get; set; }
    }
}
