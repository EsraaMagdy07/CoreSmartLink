using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UserArtist
    {
        public UserArtist()
        {
            UserContent = new HashSet<UserContent>();
        }

        public int Id { get; set; }
        public string ArtistNameEn { get; set; }
        public string ArtistNameAr { get; set; }
        public int? UserImageId { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual UserImage UserImage { get; set; }
        public virtual ICollection<UserContent> UserContent { get; set; }
    }
}
