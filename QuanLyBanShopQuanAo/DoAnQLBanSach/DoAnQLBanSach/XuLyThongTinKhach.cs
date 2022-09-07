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
    class XuLyThongTinKhach
    {
        //ham ket noi
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        //b1 tao dataSet
        DataSet ds_QLKH = new DataSet();
        //tao doi tuong sqldataadapter
        SqlDataAdapter da;
        public XuLyThongTinKhach()
        {
           

        }
        //kiểm tra rỗng
        public bool KTRong(string ten, string dt, string dc)
        {
            if (ten.Length == 0)//rỗng
            {
                MessageBox.Show("Tên khách hàng Không Để trống", "Thông Báo");
                return false;
            }
            if (dt.Length == 0)//rỗng
            {
                MessageBox.Show("Điện thoại Không Để trống", "Thông Báo");
                return false;
            }
            if (dc.Length == 0)//rỗng
            {
                MessageBox.Show("Địa chỉ Không Để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        //load  hien thi thong tin người dung
        public DataTable LoadThongTin(string mak)
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from Khach where MaKH='"+mak+"'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLKH, "Khach");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["Khach"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLKH.Tables["Khach"].PrimaryKey = key;
            return ds_QLKH.Tables["Khach"];
        }
        //sua
        public bool Sua(string m, string t, string dt, string dc)
        {
            try
            {
                da = new SqlDataAdapter("select * from Khach", con);
                //1. Tim dong du lieu can sua 
                DataRow rowData = ds_QLKH.Tables["Khach"].Rows.Find(m);//Find chi co tac dung khi co khac chinh                                                      //2. sua dong  table khoa tren dataset
                rowData["TenKH"] = t;
                rowData["DienThoai"] = dt;
                rowData["DiaChi"] = dc;
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                                                                    //update vao DB
                da.Update(ds_QLKH, "Khach");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
        }
    }
}
