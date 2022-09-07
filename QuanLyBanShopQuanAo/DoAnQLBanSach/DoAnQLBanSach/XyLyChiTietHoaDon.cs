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
    class XyLyChiTietHoaDon
    {
        //ham ket noi
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
        public XyLyChiTietHoaDon()
        {
            LoadCTHoaDon();

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
        //kiểm tra so luong
        public bool ktsoluong(string pmh,int sl)
        {
            try
            {
                //mo csdl
                if (con.State == ConnectionState.Closed)//nếu nó đang đóng
                {
                    con.Open();//mở kết nối
                }
                //cau truy van
                string sql = "select SL from Hang where MaHang='"+pmh+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //thuc thi cau truy van
                int kq = (int)cmd.ExecuteScalar();//ho tro tra tra ve 1 du lieu don
                //dong csld
                if (con.State == ConnectionState.Open)//nếu nó đang mở
                {
                    con.Close();//Đóng kết nối
                }
                if (kq >= sl)//số lượng đủ
                {
                    return true;
                }
                else//so lượng thiếu
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
        //kiểm tra khóa chính
        public bool ktkhoaC(string pvalue,string bvalue)
        {
            object keyval = new object[] { pvalue, bvalue };
            da = new SqlDataAdapter("select * from Hang", con);
            DataRow row = ds_QLKH.Tables["Hang"].Rows.Find(keyval);//tim khoa chinh
            if (row != null)//trung khoa chinh
            {
                return false;
            }
            return true;//không tồn tại khóa chính
                        //try
                        //{
                        //    //mo csdl
                        //    if (con.State == ConnectionState.Closed)//nếu nó đang đóng
                        //    {
                        //        con.Open();//mở kết nối
                        //    }

            //    //cau truy van
            //    string sql = "select count(*) from ChiTietHD where MaHD='" + pvalue+ "' and MaHang='" + bvalue+"'";
            //    SqlCommand cmd = new SqlCommand(sql, con);
            //    //thuc thi cau truy van
            //    int kq = (int)cmd.ExecuteScalar();//ho tro tra tra ve 1 du lieu don
            //    //dong csld
            //    if (con.State == ConnectionState.Open)//nếu nó đang mở
            //    {
            //        con.Close();//Đóng kết nối
            //    }
            //    if (kq >= 1)//trung khoa chinh
            //    {
            //        return false;
            //    }
            //    else//khong trung khoa chinh
            //    {
            //        return true;
            //    }

            //}
            //catch
            //{
            //    return false;
            //}
        }
        //hien thi don gia
        public int showdongia(string pvalue)
        {
            try
            {
                //mo csdl
                if (con.State == ConnectionState.Closed)//nếu nó đang đóng
                {
                    con.Open();//mở kết nối
                }
                //cau truy van
                string sql = "select DonGiaBan from Hang where MaHang='" + pvalue + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //thuc thi cau truy van
                int kq = (int)cmd.ExecuteScalar();//ho tro tra tra ve 1 du lieu don
                //dong csld
                if (con.State == ConnectionState.Open)//nếu nó đang mở
                {
                    con.Close();//Đóng kết nối
                }
                return kq;

            }
            catch
            {
                return -1;
            }
        }
        //load chi tiet hoa don
        public DataTable LoadCTHoaDon()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from ChiTietHD", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "ChiTietHD");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[2];
            key[0] = ds_QLKH.Tables["ChiTietHD"].Columns[0];//colum 0 duoc chon
            key[1] = ds_QLKH.Tables["ChiTietHD"].Columns[1];
            //set khoa chinh
            ds_QLKH.Tables["ChiTietHD"].PrimaryKey = key;
            return ds_QLKH.Tables["ChiTietHD"];
        }

        //tra ve ds sinh vien
        public DataTable LoadDataCTHoaDon()
        {
            return ds_QLKH.Tables["ChiTietHD"];
        }
        //load combobox mã hang
        public DataTable loadcbbMaHang()
        {
            da = new SqlDataAdapter("select * from Hang", con);
            da.Fill(ds_QLKH, "Hang");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["Hang"].Columns[0];
            ds_QLKH.Tables["Hang"].PrimaryKey = key;
            return ds_QLKH.Tables["Hang"];
        }
        //load combobox mã ma hoa don
        public DataTable loadcbbhoadon()
        {
            da = new SqlDataAdapter("select * from HDBan", con);
            da.Fill(ds_QLKH, "HDBan");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["HDBan"].Columns[0];
            ds_QLKH.Tables["HDBan"].PrimaryKey = key;
            return ds_QLKH.Tables["HDBan"];
        }
        //load combobox ma hoa don chua thanh toan
        public DataTable loadmahoadonchuathanhtoan()
        {
            da = new SqlDataAdapter("select * from HDBan where TinhTrang!=N'Đã thanh toán'", con);
            da.Fill(ds_QLKH, "HDBan_DaTT");
            //khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["HDBan_DaTT"].Columns[0];
            ds_QLKH.Tables["HDBan_DaTT"].PrimaryKey = key;
            return ds_QLKH.Tables["HDBan_DaTT"];
        }
        //thêm
        public bool them(string m, string mh, int sl, int dg)
        {
            try
            {
                //mo csdl
                if (con.State == ConnectionState.Closed)//nếu nó đang đóng
                {
                    con.Open();//mở kết nối
                }
                SqlCommand cmd = new SqlCommand("exec btnthemcthoadon '" + m + "','" + mh + "',N'" + sl + "','" + dg + "'", con);
                cmd.ExecuteNonQuery();//thuc thi cau len insert
                                      //đóng kết nối
                if (con.State == ConnectionState.Open)//nếu nó đang mở
                {
                    con.Close();//Đóng kết nối
                }
                return true;//thanh cong
            }
            catch
            {
                return false;//that bai
            }
        }
        //Xoa
        public bool xoa(string m, string mh)
        {
            try
            {
                //mo csdl
                if (con.State == ConnectionState.Closed)//nếu nó đang đóng
                {
                    con.Open();//mở kết nối
                }
                SqlCommand cmd = new SqlCommand("delete ChiTietHD where MaHD='"+m+"' and MaHang='"+mh+"'", con);
                cmd.ExecuteNonQuery();//thuc thi cau len insert
                                      //đóng kết nối
                if (con.State == ConnectionState.Open)//nếu nó đang mở
                {
                    con.Close();//Đóng kết nối
                }
                return true;//thanh cong
            }
            catch
            {
                return false;//that bai
            }
        }
        //sua
        public bool sua(string m, string mh, int sl, int dg)
        {
            try
            {
                //mo csdl
                if (con.State == ConnectionState.Closed)//nếu nó đang đóng
                {
                    con.Open();//mở kết nối
                }
                SqlCommand cmd = new SqlCommand("update ChiTietHD set SL='"+sl+"',DonGia='"+dg+"' where MaHD='"+m+"' and MaHang='"+mh+"'", con);
                cmd.ExecuteNonQuery();//thuc thi cau len insert
                //đóng kết nối
                if (con.State == ConnectionState.Open)//nếu nó đang mở
                {
                    con.Close();//Đóng kết nối
                }
                return true;//thanh cong
            }
            catch
            {
                return false;//that bai
            }
        }//kt hoa don da thanh toán
        public bool KThddathanhtoan(string mhd)
        { 
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select count(*) from HDBan where MaHD='" + mhd+ "' and TinhTrang=N'Đã thanh toán'", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                if (kq > 0)//so luong du
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
        //kt so luong hang
        public bool KTsoluonghang(string mhd, string mh, int sl)
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select COUNT(*) from Hang where SL>=(select " + sl + "-SL from ChiTietHD where MaHD='" + mhd + "' and MaHang='" + mh + "') and MaHang='" + mh + "'", con);
                int kq = (int)cmd.ExecuteScalar();//thuc thi cau len insert
                                                  //đóng kết nối
                closeConnection();
                if (kq > 0)//so luong du
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
    }
}
