using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UserTracks
    {
        public UserTracks()
        {
            UserContent = new HashSet<UserContent>();
        }

        public int Id { get; set; }
        public string TrackName { get; set; }
        public string TrackPath { get; set; }
        public double? Duration { get; set; }
        public DateTime? InsertionDate { get; set; }

        public virtual ICollection<UserContent> UserContent { get; set; }
    }
}
