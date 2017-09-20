using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tblquanlychinhanh
    {
        public int Iduser { get; set; }
        public int Idchinhanh { get; set; }
        public bool? Trangthaiquanly { get; set; }

        public Tblchinhanh IdchinhanhNavigation { get; set; }
        public Tblnhanvien IduserNavigation { get; set; }
    }
}
