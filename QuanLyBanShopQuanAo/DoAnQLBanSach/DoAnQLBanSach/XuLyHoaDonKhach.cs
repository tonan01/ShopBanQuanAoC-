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
   public class XuLyHoaDonKhach
    {
        //ham ket noi
        public static string TenDangNhap = "";
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        //b1 tao dataSet
        DataSet ds_QLKH = new DataSet();
        //tao doi tuong sqldataadapter
        SqlDataAdapter da;
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
        public XuLyHoaDonKhach()
        {
            LoadHoaDon();
        }
        //load sinh vien
        public void LoadHoaDon()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from HDBan where MaKH='"+TenDangNhap+ "' and TinhTrang!=N'Đã thanh toán'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "HDBan");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["HDBan"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLKH.Tables["HDBan"].PrimaryKey = key;
           
        }
        public DataTable LoadDataHoaDon()
        {
            return ds_QLKH.Tables["HDBan"];
        }
        //đăng ký tài khoản
        public bool ktrong(string pvalue)
        {
            if(pvalue=="")
            {
                MessageBox.Show("Chưa chọn mã hóa đơn", "Thông Báo");
                return false;
            }
            return true;
        }
        public bool HuyHoaDon(string mhd)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("exec huyhoadon '" + mhd + "'", con);
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
        //show tổng tiền
        public int HienThiTongTien()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select sum(TongTien) from HDBan where MaKH='"+TenDangNhap+"' and TinhTrang=N'Trong giỏ'", con);
                int kq=(int)cmd.ExecuteScalar();//thuc thi cau len insert
                                      //đóng kết nối
                closeConnection();
                return kq;//thanh cong
            }
            catch
            {
                return 0;//that bai
            }
        }
        //kiem tra da dat hang
        public bool KTdathang(string mhd)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select COUNT(*) from HDBan where TinhTrang!=N'Trong giỏ' and MaHD='"+mhd+"'", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                if(kq>0)//đã đặt hàng
                {
                    return false;
                }
                else//chưa đặt
                {
                    return true;
                }
            }
            catch
            {
                return false;//that bai
            }
        }
        //đăt hàng
        public bool Dat(string mhd)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("update HDBan set TinhTrang=N'Đang xử lý' where MaHD='"+mhd+"'", con);
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
    }
}
