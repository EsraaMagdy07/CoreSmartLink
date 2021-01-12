using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Documentation = new HashSet<Documentation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Documentation> Documentation { get; set; }
    }
}
