﻿using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class AdvanceMonthlyPaymentsAlertingLogs
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public DateTime? SendDateTime { get; set; }
        public int? ProviderLegalId { get; set; }
        public int? YearDate { get; set; }
        public int? MonthDate { get; set; }
    }
}
