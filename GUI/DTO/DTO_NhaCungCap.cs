using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_NhaCungCap
    {
            public string MaNCC { get; set; }
            public string TenNhaCungCap { get; set; }
            public string DiaChi { get; set; }
            public string SDT { get; set; }
            public DTO_NhaCungCap()
            {

            }
            public DTO_NhaCungCap(string MaNCC, string TNCC, string DC, string SDT)
            {
                this.MaNCC = MaNCC;
                this.TenNhaCungCap = TNCC;
                this.DiaChi = DC;
                this.SDT = SDT;
            }
        }
}
