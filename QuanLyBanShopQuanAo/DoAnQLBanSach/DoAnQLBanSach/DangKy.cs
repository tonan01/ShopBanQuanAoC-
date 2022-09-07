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
    public partial class DangKy : Form
    {
        XuLyDangKy dt = new XuLyDangKy();
        public DangKy()
        {
            InitializeComponent();
        }
        // tro lai
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Trở lại nơi Đăng Nhập không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DangNhap d = new DangNhap();
                this.Hide();
                d.Show();
            }
        }
        //dang ky
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (dt.ktkhoaC(txt_taikhoan.Text)==false)//trùng khóa chính
            {
                MessageBox.Show("Tài Khoản Đã tồn tại", "Thông báo");
                return;
            }
            if (dt.TaoTaiKhoan(txt_taikhoan.Text, txt_password.Text, txt_hoTen.Text, txt_dienthoai.Text, txt_diachi.Text))
            {
                MessageBox.Show("Thành công", "Thông báo");
                DangNhap d = new DangNhap();
                this.Hide();
                d.Show();
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo");
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            txt_taikhoan.Clear();
        }
    }
}
