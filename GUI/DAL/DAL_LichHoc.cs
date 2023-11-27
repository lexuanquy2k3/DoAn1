using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_LichHoc: DBConnect
    {
        public DataTable getLichHoc()
        {
            con.Open();
            string chuoiklBD = "select thu,tiet,tenMH,maLop,phongHoc,maGV,tenGV,sdt From LichHoc where maTuanHoc=N'Tuần 17' and maLop='125214'";
            SqlDataAdapter da = new SqlDataAdapter(chuoiklBD, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable loadTuanHoc()
        {
            string a1 = "select * from TuanHoc";
            SqlDataAdapter da = new SqlDataAdapter(a1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable loadngaybatdau(DTO_TuanHoc dtoTHoc)
        {
            string a1 = "select * from TuanHoc as TH where TH.maTuanHoc=N'"+dtoTHoc.maTuanHoc.Trim()+"'";
            SqlDataAdapter da = new SqlDataAdapter(a1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable loadngayketthuc(DTO_TuanHoc dtoTHoc)
        {
            string a1 = "select * from TuanHoc as TH where TH.maTuanHoc=N'" + dtoTHoc.maTuanHoc.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(a1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getLichHocTheotuan(DTO_LichHoc dtoLichHoc)
        {
            string chuoiklBD = "select thu,tiet,tenMH,maLop,phongHoc,maGV,tenGV,sdt From LichHoc where maTuanHoc=N'"+dtoLichHoc.maTuanHoc+"' and maLop='"+dtoLichHoc.maLop+"'";
            SqlDataAdapter da = new SqlDataAdapter(chuoiklBD, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable loadTenMonHoc()
        {
            string a1 = "select * from MonHoc";
            SqlDataAdapter da = new SqlDataAdapter(a1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable loadMaGiaoVien()
        {
            string a1 = "select * from GiaoVien";
            SqlDataAdapter da = new SqlDataAdapter(a1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable loadLop()
        {
            string a1 = "select * from Lop";
            SqlDataAdapter da = new SqlDataAdapter(a1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable loadTenGiaoVien(DTO_GiaoVien dtoGV)
        {
            string a1 = "select * from GiaoVien as GV where GV.maGV=N'" + dtoGV.maGV.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(a1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable loadTTGiaoVien(DTO_ThongTinGiaoVien dtottgv)
        {
            string a1 = "select * from ThongTinGiaoVien as TTGV where TTGV.maGV=N'" + dtottgv.maGV.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(a1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool themLichHoc(DTO_LichHoc themLichHoc)
        {
            string chuoithemlichhoc = "insert INTO LichHoc values (N'"+themLichHoc.maTuanHoc.Trim() +"',N'" + themLichHoc.thu.Trim() 
                + "',N'" + themLichHoc.tiet.Trim() + "',N'" + themLichHoc.tenMH.Trim() + "',N'" + themLichHoc.maLop.Trim() + "',N'" 
                + themLichHoc.phongHoc.Trim() + "','" + themLichHoc.maGV.Trim() + "',N'" + themLichHoc.tenGV.Trim() + "','" 
                + themLichHoc.sdt.Trim() + "')";
            thucthisql(chuoithemlichhoc);
            return true;
        }
        public bool suaLichHoc(DTO_LichHoc suaLichHoc)
        {
            string chuoisua = "update LichHoc set tiet= N'" +suaLichHoc.tiet.Trim() 
                + "',tenMH=N'"+suaLichHoc.tenMH.Trim()+"',phongHoc=N'" + suaLichHoc.phongHoc.Trim() 
                + "',maGV=N'"+suaLichHoc.maGV.Trim()+"',tenGV=N'" + suaLichHoc.tenGV.Trim()+ "',sdt='" + suaLichHoc.sdt.Trim() 
                + "'where maTuanHoc=N'"+suaLichHoc.maTuanHoc.Trim()+ "'and maLop=N'"+suaLichHoc.maLop.Trim()+"'and thu= N'"
                +suaLichHoc.thu.Trim()+"'";
            thucthisql(chuoisua);
            return true;
        }
        public bool xoaLichHoc(DTO_LichHoc xoaLichHoc)
        {
            string chuoixoa = "DELETE LichHoc WHERE maTuanHoc= N'" + xoaLichHoc.maTuanHoc.Trim()
                + "'and thu= N'" + xoaLichHoc.thu.Trim() + "'and maLop ='" + xoaLichHoc.maLop.Trim() + "'";
            thucthisql(chuoixoa);
            return true;
        }

        public DataTable getLichDayGiaoV(DTO_LichHoc dtoLichHocNe)
        {
            string chuoiklBD9 = "select thu,tiet,tenMH,maLop,phongHoc,maGV,tenGV,sdt From LichHoc where maTuanHoc=N'" + dtoLichHocNe.maTuanHoc + "' and maGV='" + dtoLichHocNe.maGV + "'";
            SqlDataAdapter da = new SqlDataAdapter(chuoiklBD9, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
