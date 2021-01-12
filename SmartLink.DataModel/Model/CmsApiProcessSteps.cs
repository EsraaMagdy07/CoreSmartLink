using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class CmsApiProcessSteps
    {
        public int Id { get; set; }
        public int? Step { get; set; }
        public string Description { get; set; }
    }
}
