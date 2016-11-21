using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCuaHangNoiThat.Entities;

namespace QuanLyCuaHangNoiThat.DataAccessLayer
{
   public class DataAccessHelper
    {
         public static string strKetNoi = @"Data Source=.;Initial Catalog=QuanLyCuaHangNoiThat;Integrated Security=True";
         public static SqlConnection sqlCon;// Kết nối csdl
         public static SqlCommand sqlCom;// dtuong thuc thi cau lenh trong csdl
         public static SqlDataAdapter sqlAdap;// Áp dụng cho mô hình phi kết nối
         public static DataTable dt;
        public  static void MoKetNoi()
        {
           sqlCon = new SqlConnection(strKetNoi);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }
        public static void DongKetNoi()
        {
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }
        public void ThucThiCauLenhSQL(string strSQL)
        {
            MoKetNoi();
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();//pthuc thêm sửa xóa(trả về gtri kiểu int)
            DongKetNoi();
        }
        public DataTable GetDataTable(string strDataTable)
        {
            MoKetNoi();
            sqlAdap = new SqlDataAdapter(strDataTable, sqlCon);
            dt = new DataTable();
            sqlAdap.Fill(dt);
            DongKetNoi();
            return dt;
        }
        // phương thức lấy về giá trị duy nhất của câu lệnh select
        public int GetValue(string strValue)
        {
            MoKetNoi();
            sqlCom = new SqlCommand(strValue, sqlCon);
            int so = (int)sqlCom.ExecuteScalar();//pthuc lay gtri duy nhat
            DongKetNoi();
            return so;
        }
        // Kiểm tra mã có trùng không
        //public bool KiemTraMaTrung(string strKTMaTrung)
        //{
        //    MoKetNoi();
        //    sqlCom = new SqlCommand(strKTMaTrung, sqlCon);
        //    int so = (int)sqlCom.ExecuteScalar();
        //    DongKetNoi();
        //    if (so > 0)
        //        return true;// trùng mã
        //    else
        //        return false; // mã đó chưa tồn tại 
        //}
    }  
}
