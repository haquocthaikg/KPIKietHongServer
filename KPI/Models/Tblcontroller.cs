using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tblcontroller
    {
        public Tblcontroller()
        {
            Tblquyencontroller = new HashSet<Tblquyencontroller>();
        }

        public string Idcontroller { get; set; }
        public string Chucnang { get; set; }

        public ICollection<Tblquyencontroller> Tblquyencontroller { get; set; }
    }
}
