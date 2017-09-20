using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tblquyencontroller
    {
        public Tblquyencontroller()
        {
            Tblquyenuser = new HashSet<Tblquyenuser>();
        }

        public int Idquyen { get; set; }
        public string Tenquyen { get; set; }
        public string Motaquyen { get; set; }
        public string Idcontroller { get; set; }

        public Tblcontroller IdcontrollerNavigation { get; set; }
        public ICollection<Tblquyenuser> Tblquyenuser { get; set; }
    }
}
