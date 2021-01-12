﻿using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProvidersAdminsList
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsUpdateAdmin { get; set; }
        public bool IsShiftAdmin { get; set; }

        public virtual Users User { get; set; }
    }
}
