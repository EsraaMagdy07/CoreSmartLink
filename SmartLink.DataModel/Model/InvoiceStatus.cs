using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class InvoiceStatus
    {
        public InvoiceStatus()
        {
            Invoices = new HashSet<Invoices>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
