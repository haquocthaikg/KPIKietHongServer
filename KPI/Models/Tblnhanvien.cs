using System;
using System.Collections.Generic;

namespace KPI.Models
{
    public partial class Tblnhanvien
    {
        public Tblnhanvien()
        {
            Tbldanhgia = new HashSet<Tbldanhgia>();
            Tblquanlychinhanh = new HashSet<Tblquanlychinhanh>();
            Tblquyenuser = new HashSet<Tblquyenuser>();
        }

        public int Iduser { get; set; }
        public string Tennhanvien { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Tolken { get; set; }
        public string Email { get; set; }
        public string Sodienthoai { get; set; }
        public string Secrect { get; set; }
        public string Keychung { get; set; }
        public string Keyrieng { get; set; }
        public bool? Khoa { get; set; }
        public string Giatrixacthuc { get; set; }
        public int? Idchinhanh { get; set; }
        public bool? Isadmin { get; set; }

        public Tblchinhanh IdchinhanhNavigation { get; set; }
        public ICollection<Tbldanhgia> Tbldanhgia { get; set; }
        public ICollection<Tblquanlychinhanh> Tblquanlychinhanh { get; set; }
        public ICollection<Tblquyenuser> Tblquyenuser { get; set; }
    }
}
