using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UserContent
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? AlbumId { get; set; }
        public int? ArtistId { get; set; }
        public int? UserId { get; set; }
        public int? CategoryId { get; set; }
        public string Isrc { get; set; }
        public int? TrackId { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual UserAlbum Album { get; set; }
        public virtual UserArtist Artist { get; set; }
        public virtual CmsCatalog Category { get; set; }
        public virtual UserTracks Track { get; set; }
    }
}
