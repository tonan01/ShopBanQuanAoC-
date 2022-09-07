using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnQLBanSach
{
    public class XuLyDangNhap
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
        //kiem tra ket noi co thanh cong hay khong
        
        public bool KiemTraKetNoi(string tensv)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source="+tensv+"; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
                con.Open();
                con.Close();
                return true;//thanh cong
            }
            catch
            {
                return false;//that ba
            }
        }

        //kiểm tra rỗng
        public bool KTRong(string a, string b)
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
            return true;
        }
        //kiểm tra đăng nhập thành công hay thất bại
        public bool KTDangNhap(string a,string b)
        {
            if (KTRong(a, b))
            {
                try
                {
                    //mở kết nối
                    openConnection();
                    string sql = "select count(*) from DangNhap where TaiKhoan='" + a + "' and Pass='" + b + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //thực thi câu lên noquery là thực thi insert,update,delete    ExecuteScalar là trả về 1 số
                    int k = (int)cmd.ExecuteScalar();//trả về 1 số
                    //dong ket noi
                    closeConnection();
                    if (k > 0)//đăng nhập thành công
                    {
                        return true;
                    }
                    else//that bai
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;//that bai
                }
            }
            else
            {
                return false;
            }
        }
        //kiểm tra đăng nhập vao trang quan ly
        public bool KTVaoformQL(string tk)
        {
            try
            {
                //mở kết nối
                openConnection();
                string sql = "select COUNT(*) from dangnhap where TaiKhoan='"+tk+"' and MaQuyen!='k'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //thực thi câu lên noquery là thực thi insert,update,delete    ExecuteScalar là trả về 1 số
                int k = (int)cmd.ExecuteScalar();//trả về 1 số
                                                 //dong ket noi
                closeConnection();
                if (k > 0)//đăng nhập thành công
                {
                    return true;
                }
                else//that bai
                {
                    return false;
                }
            }
            catch
            {
                return false;//that bai
            }
        }
        //thoát
        public void thoat()
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát!", "Thông Báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ServerNameAdmin = "";
           
                Application.Exit();
            }
        }
    }
}
