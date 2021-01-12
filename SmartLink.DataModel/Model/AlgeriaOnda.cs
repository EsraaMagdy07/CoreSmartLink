using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AlgeriaOnda
    {
        public int Id { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? Onda { get; set; }
        public decimal? OndaBased { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
