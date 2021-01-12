using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class UserNewsLetterRel
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? NewsLetterId { get; set; }
        public DateTime? SendingDate { get; set; }
        public string AlternativeEmail { get; set; }

        public virtual NewsLetter NewsLetter { get; set; }
        public virtual Users User { get; set; }
    }
}
