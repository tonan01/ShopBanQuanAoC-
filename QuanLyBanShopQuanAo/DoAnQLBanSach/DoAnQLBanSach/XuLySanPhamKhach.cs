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
   public class XuLySanPhamKhach
    {
        //ham ket noi
        public static string TenDangNhap = "";
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        DataSet ds_QLSV = new DataSet();
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
        public XuLySanPhamKhach()
        {
            
        }
        //kiem tra so luong hang co du dung hay khong
        public bool SoLuongKho(string mh,int sl)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select COUNT(*) from Hang where SL>="+sl+" and MaHang='"+mh+"'", con);
                int kq = (int)cmd.ExecuteScalar();//tra ve so
                closeConnection();
                if (kq > 0)
                {
                    return true;//đủ số lượng
                }
                else
                {
                    return false;//không đủ số lượng
                }
            }
            catch
            {
                return false;//that bai
            }
        }
        //tim hang
        public DataTable Timhang(string tenh)
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from Hang where TenHang like '%" + tenh + "%'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLSV, "Hang_Tim");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1]; //co 2 colum nen de so 1[co 0 va 1]
            key[0] = ds_QLSV.Tables["Hang_Tim"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLSV.Tables["Hang_Tim"].PrimaryKey = key;
            return ds_QLSV.Tables["Hang_Tim"];
        }
        //tổng số lượng hàng trong giỏ
        public int TongGioHang()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select SUM(SL) from ChiTietHD,HDBan where ChiTietHD.MaHD=HDBan.MaHD and MaKH='"+TenDangNhap+"' and TinhTrang=N'Trong giỏ'", con);
                int kq=(int)cmd.ExecuteScalar();//tra ve so
                closeConnection();
                return kq;//thanh cong
            }
            catch
            {
                return 0;//that bai
            }
        }
        //kiểm tra mua tiếp
        public bool ktMuaTep(string pvalue,string bvalue)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select COUNT(*) from ChiTietHD where MaHD='"+pvalue+"' and MaHang='"+bvalue+"'", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                if (kq > 0)//san pham co co trong gio hang
                {
                    return false;
                }
                else//san pham chưa có trong giỏ
                {
                    return true;
                }
            }
            catch
            {
                return false;//that bai
            }
        }
        //kiểm tra khóa chính hoa don
        public bool ktkhoaCHoaDon(string pvalue)
        {
            da = new SqlDataAdapter("select * from HDBan", con);
            da.Fill(ds_QLSV, "HDBan");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLSV.Tables["HDBan"].Columns[0];
            ds_QLSV.Tables["HDBan"].PrimaryKey = key;
            DataRow row = ds_QLSV.Tables["HDBan"].Rows.Find(pvalue);//tim khoa chinh
            if (row != null)//trung khoa chinh
            {
                return false;
            }
            return true;
        }
        //kiểm tra rỗng
        public bool KTRong(string mh, string sl, string dg, string mhd)
        {
            if (mh.Length == 0)//rỗng
            {
                MessageBox.Show("Mã hàng Không Để trống", "Thông Báo");
                return false;
            }
            if (sl.Length == 0)//rỗng
            {
                MessageBox.Show("Số lượng Không Để trống", "Thông Báo");
                return false;
            }
            if (dg.Length == 0)//rỗng
            {
                MessageBox.Show("Đơn giá nhập Không Để trống", "Thông Báo");
                return false;
            }
            if (mhd.Length == 0)//rỗng
            {
                MessageBox.Show("Mã hóa đơn Không Để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        //load hang
        public DataTable LoadDataHang()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from Hang", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLSV, "Hang");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1]; //co 2 colum nen de so 1[co 0 va 1]
            key[0] = ds_QLSV.Tables["Hang"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLSV.Tables["Hang"].PrimaryKey = key;
            return ds_QLSV.Tables["Hang"];
        }
        //load combobox NhanVien
        public DataTable loadcbbNhanVien()
        {
            da = new SqlDataAdapter("select * from NhanVien", con);
            da.Fill(ds_QLSV, "NhanVien");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLSV.Tables["NhanVien"].Columns[0];
            ds_QLSV.Tables["NhanVien"].PrimaryKey = key;
            return ds_QLSV.Tables["NhanVien"];
        }
        //mua
        public bool Mua(string mhd,string mk,string mh,int sl,int dg)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("exec MuaSanPham '" + mhd + "','" + mk + "','" + mh + "','" + sl + "','" + dg + "'", con);
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
        //tiếp tục mua san phẩm đó
        public bool MuaTiep(string mhd, string mk, string mh, int sl)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("exec muatiep '" + mhd + "','" + mk + "','" + mh + "','" + sl + "'", con);
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
