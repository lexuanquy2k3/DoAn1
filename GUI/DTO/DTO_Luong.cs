using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Luong
    {
            public string MaNV { get; set; }
            public float HSL { get; set; }
            public int TongSoNgayLam{ get; set; }
            public int TongLuong { get; set; }
            public DTO_Luong()
            {

            }
            public DTO_Luong(string MaNV, float HSL, int TSNL, int TL)
            {
                this.MaNV = MaNV;
                this.HSL = HSL;
                this.TongSoNgayLam = TSNL;
                this.TongLuong = TL;
            }
        }
}
