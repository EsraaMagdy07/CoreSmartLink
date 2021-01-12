using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsContentTemp
    {
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
        public int? ModeId { get; set; }
        public DateTime? InsertationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public int? Uctid { get; set; }
        public string Notes { get; set; }
        public int? ReleaseYear { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? CmsExclusivityId { get; set; }
        public int? CmsSourceId { get; set; }

        public virtual CmsAlbum Album { get; set; }
        public virtual CmsArtist Artist { get; set; }
        public virtual CmsCatalog Catalog { get; set; }
        public virtual CmsExclusivity CmsExclusivity { get; set; }
    }
}
