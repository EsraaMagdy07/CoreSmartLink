using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class RbtOperators
    {
        public RbtOperators()
        {
            PlatformsOperatorsRel = new HashSet<PlatformsOperatorsRel>();
            ProivdersOperatorsEstimatedRel = new HashSet<ProivdersOperatorsEstimatedRel>();
            ProivdersOperatorsRel = new HashSet<ProivdersOperatorsRel>();
        }

        public int Id { get; set; }
        public int? TerritoryFk { get; set; }
        public string Name { get; set; }
        public string Networkcode { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Mcc { get; set; }
        public string Mnc { get; set; }

        public virtual Territory TerritoryFkNavigation { get; set; }
        public virtual ICollection<PlatformsOperatorsRel> PlatformsOperatorsRel { get; set; }
        public virtual ICollection<ProivdersOperatorsEstimatedRel> ProivdersOperatorsEstimatedRel { get; set; }
        public virtual ICollection<ProivdersOperatorsRel> ProivdersOperatorsRel { get; set; }
    }
}
