using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient; // Thêm thư viện để làm việc với SQL
using System.Windows.Forms;

namespace QLVDV
{
    class connect
    {
       
        SqlDataAdapter da;
        DataTable tb;
        SqlConnection con;
        public static string strCn = "";

    public int ketnoi() // phuong thuc ket noi den CSDL
    {
        try
        {

            con = new SqlConnection(strCn);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                //MessageBox.Show("Ket noi thanh cong");
                return 1;// mở kết nối thành công
            }
        }
        catch (Exception ex)
        {
             MessageBox.Show(ex.Message);
        }
        return 0; // mở kết nối không thành công
    }

    public DataTable TaoBang(string sql) // Tao 1 bang moi tu cau lenh sql
    {
        da = new SqlDataAdapter(sql, con);
        tb = new DataTable(); // khoi tao mot bang moi chua co du lieu
        da.Fill(tb);
        return tb;
    }

    SqlCommand cmd;

    public void runSQL(string sql)
    {
        try
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
}
