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
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=TRUONG\SQLEXPRESS;Initial Catalog=DoAn1TruongHoc;Integrated Security=True");
    }
    public class ConnectToSQL
    {
        #region Availible
        private SqlConnection Conn;
        private SqlCommand _cmd;
        private string StrCon = null;
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }
        public SqlConnection Connection
        {
            get { return Conn; }
        }
        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        #endregion

        #region Contrustor
        public ConnectToSQL()
        {
            StrCon = @"Data Source=TRUONG\SQLEXPRESS;Initial Catalog=DoAn1TruongHoc;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
        }
        #endregion

        #region Methods
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = Conn;
            try
            {
                this.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.CloseConn();
            }
            return dt;
        }
        public bool SetData(string sql)
        {
            _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = Conn;
            try
            {
                this.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.CloseConn();
            }
            return false;
        }
        #endregion
    }
}
