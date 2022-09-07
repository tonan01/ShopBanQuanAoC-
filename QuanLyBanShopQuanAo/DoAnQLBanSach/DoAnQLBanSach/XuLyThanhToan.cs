using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBanSach
{
   public class XuLyThanhToan
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
        public XuLyThanhToan()
        {

        }
        //load hóa đơn hang chờ thanh toán
        public DataTable LoadDataHoaDonChoThanhToan()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from HDBan where  TinhTrang=N'Đang xử lý'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "HDBan");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["HDBan"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLKH.Tables["HDBan"].PrimaryKey = key;
            return ds_QLKH.Tables["HDBan"];
        }
        //load ten khach hang
        public DataTable LoadTenKhachHang()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from Khach", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "Khach");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["Khach"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLKH.Tables["Khach"].PrimaryKey = key;
            return ds_QLKH.Tables["Khach"];
        }
        //đăt hàng
        public bool ThanhToan(string mhd)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("update HDBan set TinhTrang=N'Đã thanh toán',MaNV='"+TenDangNhap+ "'where MaHD='" + mhd + "'", con);
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
        //kiểm tra có phải admin ko
        public bool KTQuyenAdmin()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select count(*) from DangNhap where TaiKhoan='" + TenDangNhap + "' and MaQuyen='ad'", con);
                int kq = (int)cmd.ExecuteScalar();//dem tra ve 1 so
                closeConnection();
                if (kq > 0)//là admin
                {
                    return true;//thanh cong
                }
                else//là nhân viên
                {
                    return false;//
                }

            }
            catch
            {
                return false;//that bai
            }
        }
    }
}
