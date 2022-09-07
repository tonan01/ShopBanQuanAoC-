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
    public partial class HomeMain : Form
    {
        public HomeMain()
        {
            InitializeComponent();
        }
        public static string TenDangNhap = "";//ten đăng nhập
        public static string ServerNameAdmin = "";//ten servername
        //ham ket noi
        SqlConnection con = new SqlConnection("Data Source="+ServerNameAdmin+"; Initial Catalog=ShopQuanAo; User ID=sa;Password=123");
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
        //kiểm tra có phải admin ko
        public bool KTQuyenAdmin()
        {
            try
            {
                //mở kết nối
                openConnection();
                SqlCommand cmd = new SqlCommand("select count(*) from DangNhap where TaiKhoan='"+TenDangNhap+"' and MaQuyen='ad'", con);
                int kq=(int)cmd.ExecuteScalar();//dem tra ve 1 so
                closeConnection();
                if(kq>0)//là admin
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
        
        //danng xuất
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeConnection();//nếu csdl đăng mở thì đống kt lại
            TenDangNhap = "";//clear lại tên đăng nhập
            DangNhap d = new DangNhap();
            this.Hide();//ẩn
            d.Show();//hiện
        }
        //quản lý tài khoản
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(KTQuyenAdmin()==false)
            {
                MessageBox.Show("Tài khoản không đủ quyền", "Thông Báo");
                return;
            }

            QLTaiKhoan q = new QLTaiKhoan();
            //đang được sử dụng
            if (KiemTraTonTai("QLTaiKhoan") == true)
            {
                q.Activate();
            }
            else
            {
                q.MdiParent = this;
                q.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HomeMain_Load(object sender, EventArgs e)
        {
            if(KTQuyenAdmin()==true)//là admin
            {
                đổiMậtKhẩuToolStripMenuItem.HideDropDown();
                thôngTinToolStripMenuItem.HideDropDown();
                
            }
            
            if (TenDangNhap.Length == 0)//chưa đăng nhập
            {
                MessageBox.Show("Bạn Chưa Đăng Nhập vào tài khoản \n Xin vui lòng đăng nhập trước", "Thông Báo");
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.Show();
            }
            else
            {
                đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
                labTennguoidung.Text = "Xin Chào, " + TenDangNhap;
            }
        }
        //khách hàng
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang k = new KhachHang();
            //đang được sử dụng
            if (KiemTraTonTai("KhachHang") == true)
            {
                k.Activate();
            }
            else
            {
                k.MdiParent = this;
                k.Show();
            }
        }
        //sản phẩm
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            //đang được sử dụng
            if (KiemTraTonTai("SanPham") == true)
            {
                sp.Activate();
            }
            else
            {
                sp.MdiParent = this;
                sp.Show();
            }
        }
        //chất liệu
        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChatLieu cl = new ChatLieu();
            //đang được sử dụng
            if (KiemTraTonTai("ChatLieu") == true)
            {
                cl.Activate();
            }
            else
            {
                cl.MdiParent = this;
                cl.Show();
            }
        }
        //nhân viên
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTQuyenAdmin() == false)
            {
                MessageBox.Show("Tài khoản không đủ quyền", "Thông Báo");
                return;
            }
            NhanVien nv = new NhanVien();
            //đang được sử dụng
            if (KiemTraTonTai("NhanVien") == true)
            {
                nv.Activate();
            }
            else
            {
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            //đang được sử dụng
            if (KiemTraTonTai("HoaDon") == true)
            {
                hd.Activate();
            }
            else
            {
                hd.MdiParent = this;
                hd.Show();
            }
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon ct = new ChiTietHoaDon();
            //đang được sử dụng
            if (KiemTraTonTai("ChiTietHoaDon") == true)
            {
                ct.Activate();
            }
            else
            {
                ct.MdiParent = this;
                ct.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowThongTinNhanVien h = new ShowThongTinNhanVien();
            //đang được sử dụng
            if (KiemTraTonTai("ShowThongTinNhanVien") == true)
            {
                h.Activate();
            }
            else
            {
                h.MdiParent = this;
                h.Show();
            }
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToan h = new ThanhToan();
            //đang được sử dụng
            if (KiemTraTonTai("ThanhToan") == true)
            {
                h.Activate();
            }
            else
            {
                h.MdiParent = this;
                h.Show();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTQuyenAdmin() == false)
            {
                MessageBox.Show("Tài khoản không đủ quyền", "Thông Báo");
                return;
            }
            ThongKe h = new ThongKe();
            //đang được sử dụng
            if (KiemTraTonTai("ThongKe") == true)
            {
                h.Activate();
            }
            else
            {
                h.MdiParent = this;
                h.Show();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTaiKhoanNhanVien h = new QLTaiKhoanNhanVien();
            //đang được sử dụng
            if (KiemTraTonTai("QLTaiKhoanNhanVien") == true)
            {
                h.Activate();
            }
            else
            {
                h.MdiParent = this;
                h.Show();
            }
        }
    }
}
