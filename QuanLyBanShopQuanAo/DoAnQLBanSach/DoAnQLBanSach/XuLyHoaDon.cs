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
    public class XuLyHoaDon
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
        public XuLyHoaDon()
        {
            LoadHoaDon();

        }
        //kiểm tra rỗng
        public bool KTRong(string mhd)
        {
            if (mhd.Length == 0)//rỗng
            {
                MessageBox.Show("Mã hóa đơn không được để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        //kiểm tra khóa chính
        public bool ktkhoaC(string pvalue)
        {
            da = new SqlDataAdapter("select * from HDBan", con);
            DataRow row = ds_QLKH.Tables["HDBan"].Rows.Find(pvalue);//tim khoa chinh
            if (row != null)//trung khoa chinh
            {
                return false;
            }
            return true;
        }
        //kiem tra khoa ngoai
        public bool ktkhoaNgoai(string pvalue)
        {
            try
            {
                //mo csdl
                if (con.State == ConnectionState.Closed)//nếu nó đang đóng
                {
                    con.Open();//mở kết nối
                }
                //cau truy van
                string sql = "select count(*) from ChiTietHD where MaHD='" + pvalue + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //thuc thi cau truy van
                int kq = (int)cmd.ExecuteScalar();//ho tro tra tra ve 1 du lieu don
                //dong csld
                if (con.State == ConnectionState.Open)//nếu nó đang mở
                {
                    con.Close();//Đóng kết nối
                }
                if (kq >= 1)//Co khóa ngoai
                {
                    return false;
                }
                else//Không có khóa ngoại
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        
        //load hoa don
        public void LoadHoaDon()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from HDBan", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "HDBan");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["HDBan"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLKH.Tables["HDBan"].PrimaryKey = key;
        }
        //tra ve ds sinh vien
        public DataTable LoadDataHoaDon()
        {
            return ds_QLKH.Tables["HDBan"];
        }
        //load combobox mã sinh viên
        public DataTable loadcbbMaSinhVien()
        {
            da = new SqlDataAdapter("select MaNV from NhanVien", con);
            da.Fill(ds_QLKH, "NhanVien");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["NhanVien"].Columns[0];
            ds_QLKH.Tables["NhanVien"].PrimaryKey = key;
            return ds_QLKH.Tables["NhanVien"];
        }
        //load combobox mã khách
        public DataTable loadcbbMaKhach()
        {
            da = new SqlDataAdapter("select MaKH from Khach", con);
            da.Fill(ds_QLKH, "Khach");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["Khach"].Columns[0];
            ds_QLKH.Tables["Khach"].PrimaryKey = key;
            return ds_QLKH.Tables["Khach"];
        }
        //thêm
        public bool them(string m, string mnv, string nb, string mkh,string tt,string ttrg)
        {
            try
            {

                //tao dong du lieu moi
                da = new SqlDataAdapter("select * from HDBan", con);
                DataRow rowData = ds_QLKH.Tables["HDBan"].NewRow();
                //gan gia tri vao rowdata
                rowData["MaHD"] = m;
                rowData["MaNV"] = mnv;
                rowData["NgayBan"] = nb;
                rowData["MaKH"] = mkh;
                rowData["TongTien"] = tt;
                rowData["TinhTrang"] = ttrg;
                //chen vao dataset
                ds_QLKH.Tables["HDBan"].Rows.Add(rowData);
                //update vao database
                SqlCommandBuilder buil = new SqlCommandBuilder(da);
                //update vao du lieu sql
                da.Update(ds_QLKH, "HDBan");
                return true;//thành công
            }
            catch
            {
                return false;//thất bại
            }

        }
        //Xoa
        public bool Xoa(string m)
        {
            try
            {
                da = new SqlDataAdapter("select * from HDBan", con);
                //1. Tim dong du lieu can xoa 
                DataRow rowData = ds_QLKH.Tables["HDBan"].Rows.Find(m);//Find chi co tac dung khi co khac chinh
                //2. xoa dong ra khoi table khoa tren dataset
                rowData.Delete();
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                //update vao DB
                da.Update(ds_QLKH, "HDBan");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
        }
        //sua
        public bool Sua(string m, string mnv, string nb, string mkh,string tt,string ttrg)
        {
            try
            {
                da = new SqlDataAdapter("select * from HDBan", con);
                //1. Tim dong du lieu can sua 
                DataRow rowData = ds_QLKH.Tables["HDBan"].Rows.Find(m);//Find chi co tac dung khi co khac chinh                                                      //2. sua dong  table khoa tren dataset
                rowData["MaHD"] = m;
                rowData["MaNV"] = mnv;
                rowData["NgayBan"] = nb;
                rowData["MaKH"] = mkh;
                rowData["TongTien"] = tt;
                rowData["TinhTrang"] = ttrg;
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                                                                    //update vao DB
                da.Update(ds_QLKH, "HDBan");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
            
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
        //kiểm tra có phải admin ko
        public bool KTQuyenAdmin(string tk)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select count(*) from DangNhap where TaiKhoan='" + tk + "' and MaQuyen='ad'", con);
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
