using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Content
    {
        public Content()
        {
            ContentChannels = new HashSet<ContentChannels>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime UploadingDate { get; set; }
        public string ContentName { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public bool ExclusiveRights { get; set; }
        public string AttachmentContentPath { get; set; }
        public bool IsApproved { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<ContentChannels> ContentChannels { get; set; }
    }
}
