using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DTO_KhachHang
    {

            public string MaKH { get; set; }
            public string TenKH { get; set; }
            public int SDT { get; set; }
            public DTO_KhachHang()
            {

            }
            public DTO_KhachHang(string MaKH, string TenKH,int SDT)
            {
                this.MaKH = MaKH;
                this.TenKH = TenKH;
                this.SDT = SDT;
            }
    }
}
