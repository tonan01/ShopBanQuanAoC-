using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBanSach
{
    public class XuLySanPham
    {
        //ham ket noi
        public static string TenDangNhap = "";//ten đăng nhập
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

        public XuLySanPham()
        {

        }
        //kiểm tra rỗng
        public bool KTRong(string a, string b, string c, string d, string e,string f)
        {
            if (a.Length == 0)//rỗng
            {
                MessageBox.Show("Mã hàng Không Để trống", "Thông Báo");
                return false;
            }
            if (b.Length == 0)//rỗng
            {
                MessageBox.Show("Tên hàng Không Để trống", "Thông Báo");
                return false;
            }
            if (c.Length == 0)//rỗng
            {
                MessageBox.Show("Số lượng Không Để trống", "Thông Báo");
                return false;
            }
            if (d.Length == 0)//rỗng
            {
                MessageBox.Show("Đơn giá nhập Không Để trống", "Thông Báo");
                return false;
            }
            if (e.Length == 0)//rỗng
            {
                MessageBox.Show("Đơn giá bán Không Để trống", "Thông Báo");
                return false;
            }
            if (f.Length == 0)//rỗng
            {
                MessageBox.Show("Ghi chú Không Để trống", "Thông Báo");
                return false;
            }
            return true;
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
        //kiểm ra đã nhập
        public bool ktClear(string a)
        {
            if(a.Length>0)//đã nhập
            {
                return false;
            }
            return true;//chưa nhập
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
        //tim hang
        public DataTable Timhang(string tenh)
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from Hang where TenHang like '%"+tenh+"%'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLSV, "Hang_Tim");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1]; //co 2 colum nen de so 1[co 0 va 1]
            key[0] = ds_QLSV.Tables["Hang_Tim"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLSV.Tables["Hang_Tim"].PrimaryKey = key;
            return ds_QLSV.Tables["Hang_Tim"];
        }
        //load combobox ma chat lieu
        public DataTable loadcbbchatlieu()
        {
            da = new SqlDataAdapter("select * from ChatLieu", con);
            da.Fill(ds_QLSV, "ChatLieu");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLSV.Tables["ChatLieu"].Columns[0];
            ds_QLSV.Tables["ChatLieu"].PrimaryKey = key;
            return ds_QLSV.Tables["ChatLieu"];
        }

        //thêm
        public bool them(string mh, string th,string cl,int sl,int dgn,int dgb,string gc, Byte[] a)
        {
            try
            {
                da = new SqlDataAdapter("select * from Hang", con);
                //tao dong du lieu moi
                DataRow rowData = ds_QLSV.Tables["Hang"].NewRow();
                //gan gia tri vao rowdata
                rowData["MaHang"] = mh;
                rowData["TenHang"] = th;
                rowData["MaChatLieu"] = cl;
                rowData["SL"] = sl;
                rowData["DonGiaNhap"] = dgn;
                rowData["DonGiaBan"] = dgb;
                rowData["GhiChu"] = gc;
                rowData["Anh"] = a;
                //chen vao dataset
                ds_QLSV.Tables["Hang"].Rows.Add(rowData);
                //update vao database
                SqlCommandBuilder buil = new SqlCommandBuilder(da);
                //update vao du lieu sql
                da.Update(ds_QLSV, "Hang");
                return true;//thành công
            }
            catch
            {
                return false;//thất bại
            }

        }
        //Xoa
        public bool Xoa(string mh)
        {
            try
            {
                da = new SqlDataAdapter("select * from Hang", con);
                //1. Tim dong du lieu can xoa 
                DataRow rowData = ds_QLSV.Tables["Hang"].Rows.Find(mh);//Find chi co tac dung khi co khac chinh
                //2. xoa dong ra khoi table khoa tren dataset
                rowData.Delete();
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                //update vao DB
                da.Update(ds_QLSV, "Hang");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
        }
        //sua
        public bool Sua(string mh, string th, string cl, int sl, int dgn, int dgb, string gc, Byte[] a)
        {
            try
            {
                //1. Tim dong du lieu can sua 
                DataRow rowData = ds_QLSV.Tables["Hang"].Rows.Find(mh);//Find chi co tac dung khi co khac chinh
                //2. sua dong  table khoa tren dataset
                rowData["TenHang"] = th;
                rowData["MaChatLieu"] = cl;
                rowData["SL"] = sl;
                rowData["DonGiaNhap"] = dgn;
                rowData["DonGiaBan"] = dgb;
                rowData["GhiChu"] = gc;
                rowData["Anh"] = a;
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                                                                    //update vao DB
                da.Update(ds_QLSV, "Hang");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
        }
        //kiểm tra khóa chính
        public bool ktkhoaC(string pvalue)
        {
            da = new SqlDataAdapter("select * from Hang", con);
            DataRow row = ds_QLSV.Tables["Hang"].Rows.Find(pvalue);//tim khoa chinh
            if (row != null)//trung khoa chinh
            {
                return false;
            }
            return true;//không tồn tại khóa chính
        }
        //kiểm tra khóa ngoại
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
                string sql = "select count(*) from ChiTietHD where MaHang='" + pvalue + "'";
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

    }
}
