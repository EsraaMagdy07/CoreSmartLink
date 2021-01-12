using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UserImage
    {
        public UserImage()
        {
            UserAlbum = new HashSet<UserAlbum>();
            UserArtist = new HashSet<UserArtist>();
        }

        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public int? Width { get; set; }
        public int? High { get; set; }
        public DateTime? InsertionDate { get; set; }

        public virtual ICollection<UserAlbum> UserAlbum { get; set; }
        public virtual ICollection<UserArtist> UserArtist { get; set; }
    }
}
