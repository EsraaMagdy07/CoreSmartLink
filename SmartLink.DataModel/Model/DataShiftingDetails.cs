using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class DataShiftingDetails
    {
        public int Id { get; set; }
        public DateTime? MonthDate { get; set; }
        public string OperatorName { get; set; }
        public string ToneCode { get; set; }
        public string ArtistName { get; set; }
        public string SongName { get; set; }
        public int? NewContractId { get; set; }
        public int? OldContractId { get; set; }
        public int? ReqId { get; set; }
    }
}
