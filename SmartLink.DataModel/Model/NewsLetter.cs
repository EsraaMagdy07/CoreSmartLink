using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class NewsLetter
    {
        public NewsLetter()
        {
            UserNewsLetterRel = new HashSet<UserNewsLetterRel>();
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime? InsertionDate { get; set; }
        public int? UserId { get; set; }
        public DateTime? SendingDate { get; set; }
        public string Subject { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<UserNewsLetterRel> UserNewsLetterRel { get; set; }
    }
}
