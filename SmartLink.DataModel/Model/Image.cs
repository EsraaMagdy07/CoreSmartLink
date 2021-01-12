using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Image
    {
        public Image()
        {
            Album = new HashSet<Album>();
            Artist = new HashSet<Artist>();
            Content1 = new HashSet<Content1>();
        }

        public int Id { get; set; }
        public int? FileDataId { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual FileData FileData { get; set; }
        public virtual ICollection<Album> Album { get; set; }
        public virtual ICollection<Artist> Artist { get; set; }
        public virtual ICollection<Content1> Content1 { get; set; }
    }
}
