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
    public partial class ThongTinKhach : Form
    {
        public ThongTinKhach()
        {
            InitializeComponent();
        }
        public static string TenDangNhap = "";
        XuLyThongTinKhach dt = new XuLyThongTinKhach();
        private void ThongTinKhach_Load(object sender, EventArgs e)
        {
            //load du leu thong tin khach hang
            dataGridViewKhachHang.DataSource = dt.LoadThongTin(TenDangNhap);
            //vo hieu hoa text box
            txt_makhachhang.Enabled = false;
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            if (dt.KTRong(txt_Tenkhachhang.Text,txt_dienthoai.Text,txt_diachi.Text) == false)
            {
                return;
            }
            if (dt.Sua(txt_makhachhang.Text,txt_Tenkhachhang.Text, txt_dienthoai.Text, txt_diachi.Text) == true)//thành công
            {
                MessageBox.Show("Thành Công", "Thông Báo");
                //reset lại dl
                dataGridViewKhachHang.DataSource = dt.LoadThongTin(TenDangNhap);
            }
            else
            {
                MessageBox.Show("Thất Bại", "Thông Báo");
                return;
            }
        }

        private void dataGridViewKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKhachHang.CurrentRow != null)
            {
                txt_makhachhang.Text = dataGridViewKhachHang.CurrentRow.Cells[0].Value.ToString();
                txt_Tenkhachhang.Text = dataGridViewKhachHang.CurrentRow.Cells[1].Value.ToString();
                txt_dienthoai.Text = dataGridViewKhachHang.CurrentRow.Cells[2].Value.ToString();
                txt_diachi.Text = dataGridViewKhachHang.CurrentRow.Cells[3].Value.ToString();
                
            }
        }
    }
}
