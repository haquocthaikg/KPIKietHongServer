﻿using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tbltonkholoi
    {
        public int Idtonkholoi { get; set; }
        public int? Idtieuchi { get; set; }
        public DateTime? Ngaychamdiem { get; set; }
        public bool? Daxuly { get; set; }
        public bool? Decen { get; set; }
    }
}
