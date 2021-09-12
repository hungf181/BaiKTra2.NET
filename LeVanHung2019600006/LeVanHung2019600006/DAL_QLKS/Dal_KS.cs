using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLKS
{
    public class Dal_KS
    {
        /*Thầy chấm bài mà database của em bị sai thuộc tính thì thầy gúp em với ạ,tại trên form có nhiều
         thuộc tính mới em định nghĩa sợ không đúng với database thầy tạo*/
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-0C8O8RG\SQLEXPRESS01;Initial Catalog=DE39;
                        Integrated Security=True");
        }
        public DataTable getTable(string query)
        {
            SqlConnection connect = getConnect();
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            connect.Close();
            return dt;
        }
        public void ExcuteNonQuery(string query)
        {
            SqlConnection connect = getConnect();
            connect.Open();
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
        public SqlCommand Command(SqlConnection connect, string query)
        {
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.CommandType = CommandType.Text;
            return cmd;
        }
    }
}
