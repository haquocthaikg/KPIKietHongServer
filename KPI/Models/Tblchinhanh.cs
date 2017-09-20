using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tblchinhanh
    {
        public Tblchinhanh()
        {
            Tblnhanvien = new HashSet<Tblnhanvien>();
            Tblquanlychinhanh = new HashSet<Tblquanlychinhanh>();
            Tbltieuchi = new HashSet<Tbltieuchi>();
        }

        public int Idchinhanh { get; set; }
        public string Machinhanh { get; set; }
        public string Tenchinhanh { get; set; }
        public bool? Tragnthaicn { get; set; }

        public ICollection<Tblnhanvien> Tblnhanvien { get; set; }
        public ICollection<Tblquanlychinhanh> Tblquanlychinhanh { get; set; }
        public ICollection<Tbltieuchi> Tbltieuchi { get; set; }
    }
}
