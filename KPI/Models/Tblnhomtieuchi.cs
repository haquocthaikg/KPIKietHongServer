using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tblnhomtieuchi
    {
        public Tblnhomtieuchi()
        {
            Tbltieuchi = new HashSet<Tbltieuchi>();
        }

        public int Idnhomtieuchi { get; set; }
        public string Tennhomtieuchi { get; set; }
        public bool? Trangthaintc { get; set; }

        public ICollection<Tbltieuchi> Tbltieuchi { get; set; }
    }
}
