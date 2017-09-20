using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tbltieuchi
    {
        public Tbltieuchi()
        {
            Tbldanhgia = new HashSet<Tbldanhgia>();
            Tbldapan = new HashSet<Tbldapan>();
        }

        public int Idtieuchi { get; set; }
        public string Matieuchi { get; set; }
        public string Tentieuchi { get; set; }
        public int? Idchinhanh { get; set; }
        public int? Idnhomtieuchi { get; set; }
        public bool? Trangthaitc { get; set; }
        public double? Diemtieuchi { get; set; }
        public int? Idloaitc { get; set; }

        public Tblchinhanh IdchinhanhNavigation { get; set; }
        public Tblloaitieuchi IdloaitcNavigation { get; set; }
        public Tblnhomtieuchi IdnhomtieuchiNavigation { get; set; }
        public Tbltieuchi IdtieuchiNavigation { get; set; }
        public Tbltieuchi InverseIdtieuchiNavigation { get; set; }
        public ICollection<Tbldanhgia> Tbldanhgia { get; set; }
        public ICollection<Tbldapan> Tbldapan { get; set; }
    }
}
