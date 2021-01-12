using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Territory
    {
        public Territory()
        {
            LoginPerCountry = new HashSet<LoginPerCountry>();
            PlatformData = new HashSet<PlatformData>();
            RbtOperators = new HashSet<RbtOperators>();
        }

        public int Id { get; set; }
        public int? CurrencyFk { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LoginPerCountry> LoginPerCountry { get; set; }
        public virtual ICollection<PlatformData> PlatformData { get; set; }
        public virtual ICollection<RbtOperators> RbtOperators { get; set; }
    }
}
