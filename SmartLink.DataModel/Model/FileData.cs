using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class FileData
    {
        public FileData()
        {
            Image = new HashSet<Image>();
            Track = new HashSet<Track>();
        }

        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string TypeExt { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }

        public virtual ICollection<Image> Image { get; set; }
        public virtual ICollection<Track> Track { get; set; }
    }
}
