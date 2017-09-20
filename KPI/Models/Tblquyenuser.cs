using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tblquyenuser
    {
        public int Idquyen { get; set; }
        public int Iduser { get; set; }

        public Tblquyencontroller IdquyenNavigation { get; set; }
        public Tblnhanvien IduserNavigation { get; set; }
    }
}
