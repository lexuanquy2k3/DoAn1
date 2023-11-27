using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_Luong
    {
            public string MaNV { get; set; }
            public string HSL { get; set; }
            public string TongSoNgayLam{ get; set; }
            public string TongLuong { get; set; }
            public DTO_Luong()
            {

            }
            public DTO_Luong(string MaNV, string HSL, string TSNL, string TL)
            {
                this.MaNV = MaNV;
                this.HSL = HSL;
                this.TongSoNgayLam = TSNL;
                this.TongLuong = TL;
            }
        }
}
