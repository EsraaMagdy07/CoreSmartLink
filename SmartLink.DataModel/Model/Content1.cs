using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Content1
    {
        public Content1()
        {
            ContentHyperLinks = new HashSet<ContentHyperLinks>();
        }

        public int Id { get; set; }
        public string Isrc { get; set; }
        public string Upc { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? ArtistId { get; set; }
        public int? CatalogId { get; set; }
        public int? AlbumId { get; set; }
        public int? ImageId { get; set; }
        public int? TrackId { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }
        public int? ExclusivityId { get; set; }
        public int? SourceId { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsPrimary { get; set; }

        public virtual Album Album { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Catalog Catalog { get; set; }
        public virtual Image Image { get; set; }
        public virtual Track Track { get; set; }
        public virtual ICollection<ContentHyperLinks> ContentHyperLinks { get; set; }
    }
}
