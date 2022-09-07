using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBanSach
{
    public class XulyThongKe
    {
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        DataSet ds_QLSV = new DataSet();
        //tao doi tuong sqldataadapter
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
        SqlDataAdapter da;

        public XulyThongKe()
        {

        }
        //show tổng tiền
        public int HienThiTongTien()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select sum(TongTien) from HDBan where TinhTrang=N'Đã thanh toán", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                return kq;//thanh cong
            }
            catch
            {
                return 0;//that bai
            }
        }
        //show tổng khach
        public int HienThiTongkhach()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select count(*) from Khach", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                return kq;//thanh cong
            }
            catch
            {
                return 0;//that bai
            }
        }
        //show tổng nhân viên
        public int HienThiTongnhanvien()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select count(*) from NhanVien", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                return kq;//thanh cong
            }
            catch
            {
                return 0;//that bai
            }
        }
        //show tổng hàng
        public int HienThiTonghang()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select sum(SL) from Hang", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                return kq;//thanh cong
            }
            catch
            {
                return 0;//that bai
            }
        }
        //show tổng loai sản phẩm
        public int HienThiTongloaisanpham()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select count(*) from Hang", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                return kq;//thanh cong
            }
            catch
            {
                return 0;//that bai
            }
        }
        //show tổng so luong san pham da ban
        public int HienThiTongsanphamdaban()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select sum(SL) from HDBan,ChiTietHD where HDBan.MaHD=ChiTietHD.MaHD and TinhTrang=N'Đã Thanh Toán'", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                return kq;//thanh cong
            }
            catch
            {
                return 0;//that bai
            }
        }
        //show tổng so luong san pham da ban
        public int HienThiTonghoadathanhtoan()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select count(*) from HDBan where TinhTrang=N'Đã Thanh Toán'", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                return kq;//thanh cong
            }
            catch
            {
                return 0;//that bai
            }
        }
    }
}
