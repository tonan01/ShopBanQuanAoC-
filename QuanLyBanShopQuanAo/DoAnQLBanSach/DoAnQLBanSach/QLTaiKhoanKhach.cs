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
    public partial class QLTaiKhoanKhach : Form
    {
        public QLTaiKhoanKhach()
        {
            InitializeComponent();
        }
        public static string TenDangNhap = "";
        XuLyQLTaiKhoanKhach dt = new XuLyQLTaiKhoanKhach();
        private void QLTaiKhoanKhach_Load(object sender, EventArgs e)
        {
            //load du lieu tai khoan 
            dataGridViewTaiKhoan.DataSource = dt.LoadTaiKhoan(TenDangNhap);
            //vo hieu hóa test box
            txt_taikhoan.Enabled = false;
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            if (dt.KTRong(txt_taikhoan.Text,txt_password.Text) == false)
            {
                return;
            }
            if(dt.Sua(txt_taikhoan.Text,txt_password.Text)==true)//thành công
            {
                MessageBox.Show("Thành Công", "Thông Báo");
                //reset lại dl
                dataGridViewTaiKhoan.DataSource = dt.LoadTaiKhoan(TenDangNhap);
            }
            else
            {
                MessageBox.Show("Thất Bại", "Thông Báo");
                return;
            }
        }

        private void dataGridViewTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTaiKhoan.CurrentRow != null)
            {
                txt_taikhoan.Text = dataGridViewTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                txt_password.Text = dataGridViewTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            }

        }
    }
}
