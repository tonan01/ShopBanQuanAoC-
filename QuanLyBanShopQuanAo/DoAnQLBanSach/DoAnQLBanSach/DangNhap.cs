using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBanSach
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static string TenDangNhap = "";
        public static string ServerNameAdmin = "";
        XuLyDangNhap dt = new XuLyDangNhap();
        public string KiemtraTenServer()
        {
            string tr = "";
            if(chk_online.Checked==true)//online
            {
               return tr="tonan01.ddns.net";
               
            }
            else//local
            {
               return tr = "DESKTOP-K7BRREB\\SQLEXPRESS";
            }
        }
        //Admin
        public void LuuBienCucBoAdmin()
        {
            //hom
            HomeMain.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap
            HomeMain.ServerNameAdmin = KiemtraTenServer();//luu ten server
            //chất liệu
            XuLyChatLieu.ServerNameAdmin = KiemtraTenServer();
            //đăng ký
            XuLyDangKy.ServerNameAdmin = KiemtraTenServer();
            //đăng nhập
            XuLyDangNhap.ServerNameAdmin = KiemtraTenServer();
            //hóa đơn
            XuLyHoaDon.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap để xử lý hiển thị
            XuLyHoaDon.ServerNameAdmin = KiemtraTenServer();
            HoaDon.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap
            //khách hàng
            XuLyKhachHang.ServerNameAdmin = KiemtraTenServer();
            //nhân viên
            XuLyNhanVien.ServerNameAdmin = KiemtraTenServer();
            //tài khoản
            XuLyQLTaiKhoan.ServerNameAdmin = KiemtraTenServer();
            //sản phẩm
            XuLySanPham.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap
            XuLySanPham.ServerNameAdmin = KiemtraTenServer();
            SanPham.ServerNameAdmin = KiemtraTenServer();
            //chi tết hóa đơn
            XyLyChiTietHoaDon.ServerNameAdmin = KiemtraTenServer();
            //thong tin nhan vien
            ThongTinNhanVien.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap
            ThongTinNhanVien.ServerNameAdmin = KiemtraTenServer();//luu ten server
            //thanh toán
            ThanhToan.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap
            XuLyThanhToan.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap
            XuLyThanhToan.ServerNameAdmin = KiemtraTenServer();//luu ten server
            // tai khoan nhân viên
            QLTaiKhoanNhanVien.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap để xử lý hiển thị
            XuLyQLTaiKhoanNhanVien.ServerNameAdmin = KiemtraTenServer();
            //thong kê
            XulyThongKe.ServerNameAdmin = KiemtraTenServer();
            //in hóa đơn
            XuLyInHoaDon.ServerNameAdmin = KiemtraTenServer();
            InHoaDon.ServerNameAdmin = KiemtraTenServer();
        }
        //khach
        public void LuuBienCucBoKhach()
        {
            HomeKhachMain.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap
            XuLyDangNhap.ServerNameAdmin = KiemtraTenServer();
            // tai khoan khách
            QLTaiKhoanKhach.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap để xử lý hiển thị
            XuLyQLTaiKhoanKhach.ServerNameAdmin = KiemtraTenServer();
            //thong tin khách
            ThongTinKhach.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap để xử lý hiển thị
            XuLyThongTinKhach.ServerNameAdmin = KiemtraTenServer();
            //san pham
            SanPhamKhach.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap để xử lý hiển thị
            XuLySanPhamKhach.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap để xử lý hiển thị
            XuLySanPhamKhach.ServerNameAdmin = KiemtraTenServer();
            
            //hoa don

            XuLyHoaDonKhach.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap để xử lý hiển thị
            XuLyHoaDonKhach.ServerNameAdmin = KiemtraTenServer();
            //chi tiết hóa don
            XuLyChiTietHoaDonKhach.TenDangNhap = txt_taikhoan.Text;//luu ten dang nhap để xử lý hiển thị
            XuLyChiTietHoaDonKhach.ServerNameAdmin = KiemtraTenServer();

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if(chk_online.Checked==true)
            {
                if(dt.KiemTraKetNoi("tonan01.ddns.net")==false)//kết nối thất bại
                {
                    MessageBox.Show("Kết nối từ xa thất bại", "Thông Báo");
                    return;
                }
            }
            XuLyDangNhap.ServerNameAdmin = KiemtraTenServer();
            if (dt.KTDangNhap(txt_taikhoan.Text, txt_password.Text))
            {
                if (dt.KTVaoformQL(txt_taikhoan.Text)==true)//vào form quản lý
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                    LuuBienCucBoAdmin();
                    HomeMain h = new HomeMain();
                    this.Hide();
                    h.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Đăng nhập Khach", "Thông Báo");
                    LuuBienCucBoKhach();
                    HomeKhachMain hk = new HomeKhachMain();
                    this.Hide();
                    hk.Show();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập Thất bại \n Xin lòng kiểm tra lại Tài khoản và Password", "Thông Báo");
            }


        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void labdangky_Click(object sender, EventArgs e)
        {
            XuLyDangKy.ServerNameAdmin = KiemtraTenServer();
            DangKy d = new DangKy();
            this.Hide();//ẩn
            d.Show();//hiện
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            TenDangNhap = "";
            ServerNameAdmin = "";
        }

        private void chk_online_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        //thoát
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
            TenDangNhap = "";//clear lại tên đăng nhập
            ServerNameAdmin = "";//clear lai ten dang nhap
        }
    }
}
