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
    public class XuLyChatLieu
    {
        //ham ket noi
        public static string ServerNameAdmin = "";//ten servername
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        //b1 tao dataSet
        DataSet ds_QLSV = new DataSet();
        //tao doi tuong sqldataadapter
        SqlDataAdapter da;
        public XuLyChatLieu()
        {
            LoadChatLieu();

        }
        //kiểm tra rỗng
        public bool KTRong(string a, string b)
        {
            if (a.Length == 0)//rỗng
            {
                MessageBox.Show("Mã chất liệu Không Để trống", "Thông Báo");
                return false;
            }
            if (b.Length == 0)//rỗng
            {
                MessageBox.Show("Tên chất liệu Không Để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        //load sinh vien
        public void LoadChatLieu()
        {
            //b1 tao doi tuong sqldataadapter
            da = new SqlDataAdapter("select * from ChatLieu", con);
            //b1 dien du lieu vao dataSet hoac goi anh xa bang khoa len dataset
            da.Fill(ds_QLSV, "ChatLieu");//ten bang muon anh xa
            //truoc khi them xoa sua can dat khoa chinh cho table khoa
            DataColumn[] key = new DataColumn[1]; //co 2 colum nen de so 1[co 0 va 1]
            key[0] = ds_QLSV.Tables["ChatLieu"].Columns[0];//colum 0 duoc chon
            //set khoa chinh
            ds_QLSV.Tables["ChatLieu"].PrimaryKey = key;
        }
        //tra ve ds sinh vien
        public DataTable LoadDataChatLieu()
        {
            return ds_QLSV.Tables["ChatLieu"];
        }
        //thêm
        public bool them(string tk, string p)
        {
            try
            {
                //tao dong du lieu moi
                DataRow rowData = ds_QLSV.Tables["ChatLieu"].NewRow();
                //gan gia tri vao rowdata
                rowData["MaChatLieu"] = tk;
                rowData["TenChatLieu"] = p;
                //chen vao dataset
                ds_QLSV.Tables["ChatLieu"].Rows.Add(rowData);
                //update vao database
                SqlCommandBuilder buil = new SqlCommandBuilder(da);
                //update vao du lieu sql
                da.Update(ds_QLSV, "ChatLieu");
                return true;//thành công
            }
            catch
            {
                return false;//thất bại
            }

        }
        //Xoa
        public bool Xoa(string tk)
        {
            try
            {
                //1. Tim dong du lieu can xoa 
                DataRow rowData = ds_QLSV.Tables["ChatLieu"].Rows.Find(tk);//Find chi co tac dung khi co khac chinh
                //2. xoa dong ra khoi table khoa tren dataset
                rowData.Delete();
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                //update vao DB
                da.Update(ds_QLSV, "ChatLieu");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
        }
        //sua
        public bool Sua(string tk, string p)
        {
            try
            {
                //1. Tim dong du lieu can sua 
                DataRow rowData = ds_QLSV.Tables["ChatLieu"].Rows.Find(tk);//Find chi co tac dung khi co khac chinh
                                                                           //2. sua dong  table khoa tren dataset
                rowData["TenChatLieu"] = p;
                //3. update vao database giup buld cau lanh them xoa sua vao bang khoa
                SqlCommandBuilder build = new SqlCommandBuilder(da);//danh dau trang trang thai
                                                                    //update vao DB
                da.Update(ds_QLSV, "ChatLieu");//khi thuc hien cau nay du lieu trong sql moi bi thay doi
                return true;//thanh cong
            }
            catch
            {

                return false;//that bai
            }
        }
        //kiem tra khoa chinh
        public bool ktkhoaC(string pvalue)
        {
            da = new SqlDataAdapter("select * from ChatLieu", con);
            DataRow row = ds_QLSV.Tables["ChatLieu"].Rows.Find(pvalue);//tim khoa chinh
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
                string sql = "select count(*) from Hang where MaChatLieu='" + pvalue + "'";
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
