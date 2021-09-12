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
            string query = "select makhachhang,hoten,sochungminhthu,gioitinh,sophong,ngay from khachsan  ";
            return dal.getTable(query);
        }
        public void Insert_X(string makh, string ten, int cmt, string gt, int sophong, string ngay)
        {
            string query = string.Format("Insert into khachsan values('{0}',N'{1}',{2},N'{3}',{4},'{5}')",makh,ten,cmt,gt,sophong,ngay);
            dal.ExcuteNonQuery(query);
        }
        public void Update_X(string makh, string ten, int cmt, string gt, int sophong, string ngay)
        {
            string query = string.Format("update khachsan set hoten=N'{0}',sochungminhthu={1},gioitinh=N'{2}',sophong={3},ngay='{4}' where makhachhang='{5}'", ten, cmt, gt, sophong, ngay,makh);
            dal.ExcuteNonQuery(query);
        }
        public void Delete_X(string makh)
        {
            string query = string.Format("delete from khachsan where makhachhang='{0}'",makh);
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
