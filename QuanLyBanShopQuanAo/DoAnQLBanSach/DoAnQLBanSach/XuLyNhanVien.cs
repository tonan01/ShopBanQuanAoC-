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
    public class XuLyNhanVien
    {
        //ham ket noi
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        //b1 tao dataSet
        DataSet ds_QLKH = new DataSet();
        //tao doi tuong sqldataadapter
        SqlDataAdapter da;
        public XuLyNhanVien()
        {
            LoadNhanVien();

        }
        //kiểm tra rỗng
        public bool KTRong(string a, string b, string c, string d)
        {
            if (a.Length == 0)//rỗng
            {
                MessageBox.Show("Mã nhân viên Không Để trống", "Thông Báo");
                return false;
            }
            if (b.Length == 0)//rỗng
            {
                MessageBox.Show("Tên nhân viên Không Để trống", "Thông Báo");
                return false;
            }
            if (c.Length == 0)//rỗng
            {
                MessageBox.Show("Điện thoại Không Để trống", "Thông Báo");
                return false;
            }
            if (d.Length == 0)//rỗng
            {
                MessageBox.Show("Địa chỉ Không Để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        //kiểm tra khóa chính
        public bool ktkhoaC(string pvalue)
        {
            da = new SqlDataAdapter("select * from NhanVien", con);
            DataRow row = ds_QLKH.Tables["NhanVien"].Rows.Find(pvalue);//tim khoa chinh
            if (row != null)//trung khoa chinh
            {
                return false;
            }
            return true;//không tồn tại khóa chính
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
                string sql = "select count(*) from HDBan where MaNV='" + pvalue + "'";
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
        //load NhanVien
        public void LoadNhanVien()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from NhanVien", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "NhanVien");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["NhanVien"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLKH.Tables["NhanVien"].PrimaryKey = key;
        }
        //tra ve ds sinh vien
        public DataTable LoadDataNhanVien()
        {
            return ds_QLKH.Tables["NhanVien"];
        }
        //thêm
        //load combobox hien thi tat cả tài khoản
        public DataTable loadcbbAllTaiKhoanNV()
        {
            da = new SqlDataAdapter("select * from DangNhap where MaQuyen='nv'", con);
            da.Fill(ds_QLKH, "DangNhap_TKNV");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["DangNhap_TKNV"].Columns[0];
            ds_QLKH.Tables["DangNhap_TKNV"].PrimaryKey = key;
            return ds_QLKH.Tables["DangNhap_TKNV"];
        }
        //load combobox hien thi  tài khoản chua co khach hang
        public DataTable loadcbbTaiKhoanChuaCoNhanVien()
        {
            da = new SqlDataAdapter("select * from dangnhap where DangNhap.TaiKhoan not in (select MaNV from NhanVien) and MaQuyen='nv'", con);
            da.Fill(ds_QLKH, "DangNhap_NhanVien");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["DangNhap_NhanVien"].Columns[0];
            ds_QLKH.Tables["DangNhap_NhanVien"].PrimaryKey = key;
            return ds_QLKH.Tables["DangNhap_NhanVien"];
        }
        public bool them(string m, string t,string gt, string dt, string dc)
        {
            try
            {

                //tao dong du lieu moi
                da = new SqlDataAdapter("select * from NhanVien", con);
                DataRow rowData = ds_QLKH.Tables["NhanVien"].NewRow();
                //gan gia tri vao rowdata
                rowData["MaNV"] = m;
                rowData["TenNV"] = t;
                rowData["GioiTinh"] = gt;
                rowData["DienThoai"] = dt;
                rowData["DiaChi"] = dc;
                //chen vao dataset
                ds_QLKH.Tables["NhanVien"].Rows.Add(rowData);
                //update vao database
                SqlCommandBuilder buil = new SqlCommandBuilder(da);
                //update vao du lieu sql
                da.Update(ds_QLKH, "NhanVien");
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
                da = new SqlDataAdapter("select * from NhanVien", con);
                //1. Tim dong du lieu can xoa 
                DataRow rowData = ds_QLKH.Tables["NhanVien"].Rows.Find(m);//Find chi co tac dung khi co khac chinh
                //2. xoa dong ra khoi table khoa tren dataset
                rowData.Delete();
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                //update vao DB
                da.Update(ds_QLKH, "NhanVien");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
        }
        //sua
        public bool Sua(string m, string t,string gt, string dt, string dc)
        {
            try
            {
                da = new SqlDataAdapter("select * from NhanVien", con);
                //1. Tim dong du lieu can sua 
                DataRow rowData = ds_QLKH.Tables["NhanVien"].Rows.Find(m);//Find chi co tac dung khi co khac chinh                                                      //2. sua dong  table khoa tren dataset
                rowData["TenNV"] = t;
                rowData["GioiTinh"] = gt;
                rowData["DienThoai"] = dt;
                rowData["DiaChi"] = dc;
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                                                                    //update vao DB
                da.Update(ds_QLKH, "NhanVien");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
        }
    }
}
