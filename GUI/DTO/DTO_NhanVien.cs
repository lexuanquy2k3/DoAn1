using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        public int CCCD { get; set; }
        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien(string MaNV, string TenNV, string NS, string GT, string DC, int SDT, int CCCD)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.NgaySinh = NS;
            this.GioiTinh = GT;
            this.DiaChi =DC;
            this.SDT = SDT;
            this.CCCD = CCCD;        }
    }
}
