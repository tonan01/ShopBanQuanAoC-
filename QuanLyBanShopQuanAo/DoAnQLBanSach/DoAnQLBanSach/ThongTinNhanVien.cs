using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBanSach
{
   public class ThongTinNhanVien
    {
        //ham ket noi
        public static string TenDangNhap = "";
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        DataSet ds_QLSV = new DataSet();
        //tao doi tuong sqldataadapter
        SqlDataAdapter da;
        public ThongTinNhanVien()
        {

        }
        //load nhan vien
        public DataTable LoadShowNV()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from NhanVien where MaNV='"+TenDangNhap+"'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLSV, "NhanVien");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLSV.Tables["NhanVien"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLSV.Tables["NhanVien"].PrimaryKey = key;
            return ds_QLSV.Tables["NhanVien"];
        }
    }
}
