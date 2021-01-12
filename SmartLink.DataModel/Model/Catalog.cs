using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Catalog
    {
        public Catalog()
        {
            Content1 = new HashSet<Content1>();
        }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? ImageId { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual ICollection<Content1> Content1 { get; set; }
    }
}
