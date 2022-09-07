using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBanSach
{
   public class XuLyInHoaDon
    {

        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        //b1 tao dataSet
        DataSet ds_QLKH = new DataSet();
        //tao doi tuong sqldataadapter
        SqlDataAdapter da;
        //mở kết nói
        public XuLyInHoaDon()
        {

        }
        //load in hoa don
        public DataTable loadinhoadon(string mhd)
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select ChiTietHD.*,TinhTrang,TongTien from ChiTietHD,HDBan where ChiTietHD.MaHD=HDBan.MaHD and ChiTietHD.MaHD='"+mhd+"'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "ChiTietHD_HD");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
           
            return ds_QLKH.Tables["ChiTietHD_HD"];
        }
        
    }
}
