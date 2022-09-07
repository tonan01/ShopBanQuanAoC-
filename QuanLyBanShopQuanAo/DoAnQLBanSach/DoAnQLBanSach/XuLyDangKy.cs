using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBanSach
{
    public class XuLyDangKy
    {

        //ham ket noi
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        //mở kết nói
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)//nếu nó đang đóng
            {
                con.Open();//mở kết nối
            }
        }
        //Đống kết nối
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)//nếu nó đang mở
            {
                con.Close();//Đóng kết nối
            }
        }
        //kiểm tra rỗng
        public bool KTRong(string a, string b, string c, string d, string e)
        {
            if (a.Length == 0)//rỗng
            {
                MessageBox.Show("Tài Khoản Không Để trống", "Thông Báo");
                return false;
            }
            if (b.Length == 0)//rỗng
            {
                MessageBox.Show("Password Không Để trống", "Thông Báo");
                return false;
            }
            if (c.Length == 0)//rỗng
            {
                MessageBox.Show("Họ tên Không Để trống", "Thông Báo");
                return false;
            }
            if (d.Length == 0)//rỗng
            {
                MessageBox.Show("Điện thoại Không Để trống", "Thông Báo");
                return false;
            }
            if (e.Length == 0)//rỗng
            {
                MessageBox.Show("Địa chỉ Không Để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        //kiem tra khoa chinh
        public bool ktkhoaC(string pvalue)
        {
            try
            {
                //mo csdl
                openConnection();
                //cau truy van
                string sql = "select count(*) from dangnhap where TaiKhoan='" + pvalue + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //thuc thi cau truy van
                int kq = (int)cmd.ExecuteScalar();//ho tro tra tra ve 1 du lieu don
                //dong csld
                closeConnection();
                if (kq >= 1)//trung khoa chinh
                {
                    return false;
                }
                else//khong trung khoa chinh
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        //đăng ký tài khoản
        public bool TaoTaiKhoan(string a, string b, string c, string d, string e)
        {
            if (KTRong(a, b, c, d, e))//thoải điều kiện nhập
            {
                try
                {
                    //mở kết nối
                    openConnection();
                    SqlCommand cmd = new SqlCommand("exec themTaiKhoan '" + a + "','" + b + "',N'" + c + "','" + d + "','" + e + "'", con);
                    cmd.ExecuteNonQuery();//thuc thi cau len insert
                    //đóng kết nối
                    closeConnection();
                    return true;//thanh cong
                }
                catch
                {
                    return false;//that bai
                }
            }
            else//txtbox còn rỗng
            {
                return false;
            }
        }
    }
}
