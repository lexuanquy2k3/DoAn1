using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {

        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int DonGia { get; set; }
        public string DonViTinh { get; set; }
        public string MoTa { get; set; }
        public DTO_SanPham()
        {

        }
        public DTO_SanPham(string MaSP, string TenSP, int DG, string DVT, string MT)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.DonGia = DG;
            this.DonViTinh = DVT;
            this.MoTa = MT;
        }
    }
}

