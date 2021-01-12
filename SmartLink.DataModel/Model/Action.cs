using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Action
    {
        public Action()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
