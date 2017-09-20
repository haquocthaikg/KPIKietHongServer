using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tbldapan
    {
        public int Iddapan { get; set; }
        public int? Idtieuchi { get; set; }
        public string Tendapan { get; set; }
        public double? Diemdapan { get; set; }
        public bool? Trangthaidapan { get; set; }

        public Tbltieuchi IdtieuchiNavigation { get; set; }
    }
}
