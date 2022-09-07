using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBanSach
{
    public partial class HomeKhachMain : Form
    {
        public HomeKhachMain()
        {
            InitializeComponent();
        }
        public static string TenDangNhap = "";//ten đăng nhập
        public static string ServerNameAdmin = "";//ten servername
        //ham ket noi
        SqlConnection con = new SqlConnection("Data Source=" + ServerNameAdmin + "; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
        //Đống kết nối
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)//nếu nó đang mở
            {
                con.Close();//Đóng kết nối
            }
        }
        //kiem tra form ton tai
        public Boolean KiemTraTonTai(string Frmname)
        {
            //trong ds from con
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(Frmname))//form đang được sử dụng
                    return true;
            }
            return false;//không chưa được sử dụng
        }
        
        //kiểm tra xem đã đăng nhập hay chưa
        public bool KiemTraTrangThaiDN(string pvalue)
        {
            if(pvalue=="")//chưa đăng nhập tài khoản
            {
                return false;
            }
            return true;//dã đăng nhập
        }
        private void HomeKhachMain_Load(object sender, EventArgs e)
        {
            if(KiemTraTrangThaiDN(TenDangNhap)==true)//đã đăng nhập rồi
            {
                đăngNhậpToolStripMenuItem.Text = "Đăng Xuất";
                ngườiDùngKháchToolStripMenuItem.Text ="User: "+ TenDangNhap;
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeConnection();//nếu csdl đăng mở thì đống kt lại
            TenDangNhap = "";//clear lại tên đăng nhập
            ServerNameAdmin = "";//clear lai ten dang nhap
            DangNhap d = new DangNhap();
            this.Hide();//ẩn
            d.Show();//hiện
        }
        //thoat
        private void HomeKhachMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                
                e.Cancel = true;
            }
            closeConnection();//nếu csdl đăng mở thì đống kt lại
            TenDangNhap = "";//clear lại tên đăng nhập
            ServerNameAdmin = "";//clear lai ten dang nhap
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ngườiDùngKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrangThaiDN(TenDangNhap) == false)
            {
                MessageBox.Show("Vui lòng đăng nhập", "Thông Báo");
                return;
            }
            ThongTinKhach q = new ThongTinKhach();
            //đang được sử dụng
            if (KiemTraTonTai("ThongTinKhach") == true)
            {
                q.Activate();
            }
            else
            {
                q.MdiParent = this;
                q.Show();
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(KiemTraTrangThaiDN(TenDangNhap)==false)
            {
                MessageBox.Show("Vui lòng đăng nhập", "Thông Báo");
                return;
            }
            QLTaiKhoanKhach q = new QLTaiKhoanKhach();
            //đang được sử dụng
            if (KiemTraTonTai("QLTaiKhoanKhach") == true)
            {
                q.Activate();
            }
            else
            {
                q.MdiParent = this;
                q.Show();
            }

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrangThaiDN(TenDangNhap) == false)
            {
                MessageBox.Show("Vui lòng đăng nhập", "Thông Báo");
                return;
            }
            ThongTinKhach q = new ThongTinKhach();
            //đang được sử dụng
            if (KiemTraTonTai("ThongTinKhach") == true)
            {
                q.Activate();
            }
            else
            {
                q.MdiParent = this;
                q.Show();
            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrangThaiDN(TenDangNhap) == false)
            {
                MessageBox.Show("Vui lòng đăng nhập", "Thông Báo");
                return;
            }
            HoaDonKhach q = new HoaDonKhach();
            //đang được sử dụng
            if (KiemTraTonTai("HoaDonKhach") == true)
            {
                q.Activate();
            }
            else
            {
                q.MdiParent = this;
                q.Show();
            }
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrangThaiDN(TenDangNhap) == false)
            {
                MessageBox.Show("Vui lòng đăng nhập", "Thông Báo");
                return;
            }
            ChiTietHoaDonKhach q = new ChiTietHoaDonKhach();
            //đang được sử dụng
            if (KiemTraTonTai("ChiTietHoaDonKhach") == true)
            {
                q.Activate();
            }
            else
            {
                q.MdiParent = this;
                q.Show();
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrangThaiDN(TenDangNhap) == false)
            {
                MessageBox.Show("Vui lòng đăng nhập", "Thông Báo");
                return;
            }
            SanPhamKhach q = new SanPhamKhach();
            //đang được sử dụng
            if (KiemTraTonTai("SanPhamKhach") == true)
            {
                q.Activate();
            }
            else
            {
                q.MdiParent = this;
                q.Show();
            }
        }
    }
}
