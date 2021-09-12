using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_QLKS;

namespace BUS_QLKS
{
    public class Bus_KS
    {
        Dal_KS dal = new Dal_KS();
        public DataTable Show()
        {
            string query = "select makhachhang ,hoten,sochungminhthu,gioitinh,sophong,ngay from khachsan  ";
            return dal.getTable(query);
        }
        public void Insert_X(string makh, string ten, int cmt, string gt, int sophong, string ngay)
        {
            string query = "Insert into khachsan values('" + makh + "',N'" + ten + "','" + cmt + "',N'" + gt + "','" + sophong + "','" + ngay + "')";
            dal.ExcuteNonQuery(query);
        }
        public void Update_X(string makh, string ten, int cmt, string gt, int sophong, string ngay)
        {
            string query = "update khachsan set hoten=N'" + ten + "',sochungminhthu='" + cmt + "',gioitinh=N'" + gt + "',sophong='" + sophong + "',ngay='" + ngay + "' where makhachhang='" + makh + "'";
            dal.ExcuteNonQuery(query);
        }
        public void Delete_X(string makh)
        {
            string query = "delete from khachsan where makhachhang='" + makh + "'";
            dal.ExcuteNonQuery(query);
        }
        public bool check_key(string key)
        {
            SqlConnection connect = dal.getConnect();
            connect.Open();
            string query = "select*from khachsan where makhachhang='" + key + "'";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            connect.Close();
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
