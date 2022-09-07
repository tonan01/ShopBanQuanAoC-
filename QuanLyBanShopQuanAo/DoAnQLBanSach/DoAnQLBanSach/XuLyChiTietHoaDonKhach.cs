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
   public class XuLyChiTietHoaDonKhach
    {
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
        public XuLyChiTietHoaDonKhach()
        {
        }
        //kiểm tra rỗng
        public bool KTRong(string b)
        {
            if (b.Length == 0)//rỗng
            {
                MessageBox.Show("Số lượng không được để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        //load chi tiet hoa don theo khach
        public DataTable LoadCTHoaDonTheoKhach()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select ChiTietHD.* from ChiTietHD,HDBan WHERE ChiTietHD.MaHD=HDBan.MaHD and TinhTrang=N'Trong giỏ' and MaKH='" + TenDangNhap+"'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "ChiTietHD_HDBan");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[2];
            key[0] = ds_QLKH.Tables["ChiTietHD_HDBan"].Columns[0];//colum 0 duoc chon la khoa thu 1
            key[1] = ds_QLKH.Tables["ChiTietHD_HDBan"].Columns[1];//khoa thu 2 o column 2
            //set khoa chinh
            ds_QLKH.Tables["ChiTietHD_HDBan"].PrimaryKey = key;
            return ds_QLKH.Tables["ChiTietHD_HDBan"];
        }
        //load combobox ma hoa don
        public DataTable LoadcomboboxMaCTHD()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select distinct ChiTietHD.MaHD from ChiTietHD,HDBan WHERE ChiTietHD.MaHD=HDBan.MaHD and TinhTrang=N'Trong giỏ' and MaKH='" + TenDangNhap + "'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "ChiTietHD_HDBan_LayMaHD");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[2];
            key[0] = ds_QLKH.Tables["ChiTietHD_HDBan_LayMaHD"].Columns[0];//colum 0 duoc chon la khoa thu 1
            //set khoa chinh
            ds_QLKH.Tables["ChiTietHD_HDBan_LayMaHD"].PrimaryKey = key;
            return ds_QLKH.Tables["ChiTietHD_HDBan_LayMaHD"];
        }
        //load combobox ten hàng
        public DataTable Loadcomboboxtenhang()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from Hang", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "Hang");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["Hang"].Columns[0];//colum 0 duoc chon la khoa thu 1
            //set khoa chinh
            ds_QLKH.Tables["Hang"].PrimaryKey = key;
            return ds_QLKH.Tables["Hang"];
        }
        //kt so luong hang
        public bool KTsoluonghang(string mhd, string mh, int sl)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select COUNT(*) from Hang where SL>=(select " + sl + "-SL from ChiTietHD where MaHD='" + mhd+ "' and MaHang='" + mh + "') and MaHang='" + mh + "'", con);
                int kq=(int)cmd.ExecuteScalar();//thuc thi cau len insert
                                      //đóng kết nối
                closeConnection();
                if(kq>0)//so luong du
                {
                    return true;//so luong du
                }
                else//khong du
                {
                    return false;//so luong khong du
                }
                
            }
            catch
            {
                return false;//that bai
            }
        }
        //sửa
        public bool Sua(string mhd,string mh,int sl)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("exec suacthdadmin '" + mhd+"','"+mh+"',"+sl+"", con);
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
        //sửa
        public bool Xoa(string mhd, string mh)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("exec xoacthdkhach '" + mhd + "','" + mh + "'", con);
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
