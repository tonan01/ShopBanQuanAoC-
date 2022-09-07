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
   public class XuLyQLTaiKhoanKhach
    {
        //ham ket noi
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        //b1 tao dataSet
        DataSet ds_QLSV = new DataSet();
        //tao doi tuong sqldataadapter
        SqlDataAdapter da;
        public XuLyQLTaiKhoanKhach()
        { 
        }
        //kiểm tra rỗng
        public bool KTRong(string tk, string pw)
        {
            if (tk.Length == 0)//rỗng
            {
                MessageBox.Show("Chưa chọn tài khoản", "Thông Báo");
                return false;
            }
            if (pw.Length == 0)//rỗng
            {
                MessageBox.Show("Password Không Để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        //load tài khoản
        public DataTable LoadTaiKhoan(string tk)
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from dangnhap where TaiKhoan='"+tk+"'", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLSV, "DangNhap");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1]; //co 2 colum nen de so 1[co 0 va 1]
            key[0] = ds_QLSV.Tables["DangNhap"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLSV.Tables["DangNhap"].PrimaryKey = key;
            return ds_QLSV.Tables["DangNhap"];//tra ve bang
        }
        //sua
        public bool Sua(string tk, string p)
        {
            try
            {
                da = new SqlDataAdapter("select * from dangnhap", con);
                //1. Tim dong du lieu can sua 
                DataRow rowData = ds_QLSV.Tables["DangNhap"].Rows.Find(tk);//Find chi co tac dung khi co khac chinh
                                                                           //2. sua dong  table khoa tren dataset
                rowData["Pass"] = p;
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                                                                    //update vao DB
                da.Update(ds_QLSV, "DangNhap");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
        }
    }
}
