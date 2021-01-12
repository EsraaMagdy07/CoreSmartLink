using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UserAlbum
    {
        public UserAlbum()
        {
            UserContent = new HashSet<UserContent>();
        }

        public int Id { get; set; }
        public string AlbumNameEn { get; set; }
        public string AlbumNameAr { get; set; }
        public int? NumberOfSongs { get; set; }
        public int? UserCoverId { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual UserImage UserCover { get; set; }
        public virtual ICollection<UserContent> UserContent { get; set; }
    }
}
