using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class PlatformsOperatorsRel
    {
        public int Id { get; set; }
        public int? PlatfromId { get; set; }
        public int? OperatorId { get; set; }

        public virtual RbtOperators Operator { get; set; }
        public virtual PlatformList Platfrom { get; set; }
    }
}
