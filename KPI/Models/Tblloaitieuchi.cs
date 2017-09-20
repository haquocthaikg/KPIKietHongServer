using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tblloaitieuchi
    {
        public Tblloaitieuchi()
        {
            Tbltieuchi = new HashSet<Tbltieuchi>();
        }

        public int Idloaitc { get; set; }
        public string Tenloaitc { get; set; }
        public bool? Trangthaitc { get; set; }

        public ICollection<Tbltieuchi> Tbltieuchi { get; set; }
    }
}
