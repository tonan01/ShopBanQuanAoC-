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
    public partial class ChiTietHoaDonKhach : Form
    {
        public ChiTietHoaDonKhach()
        {
            InitializeComponent();
        }
        XuLyChiTietHoaDonKhach dt = new XuLyChiTietHoaDonKhach();
        private void ChiTietHoaDonKhach_Load(object sender, EventArgs e)
        {
            //load du lieu chi tiết hóa đơn theo khách
            dataGridViewChiTietHoaDon.DataSource = dt.LoadCTHoaDonTheoKhach();
            //load combobox ma chi tiet hd
            cbbmahoadon.DataSource = dt.LoadcomboboxMaCTHD();
            cbbmahoadon.DisplayMember = "MaHD";
            cbbmahoadon.ValueMember = "MaHD";
            //load combobox ten hang
            cbbMaHang.DataSource = dt.Loadcomboboxtenhang();
            cbbMaHang.DisplayMember = "TenHang";
            cbbMaHang.ValueMember = "MaHang";
            //vo hieu hoa 
            txt_dongia.Enabled =cbbMaHang.Enabled=cbbmahoadon.Enabled =false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dt.KTRong(txt_soluong.Text) == false)
            {
                return;
            }
            if(dt.KTsoluonghang(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString(), int.Parse(txt_soluong.Text))==false)
            {
                MessageBox.Show("Số lượng hàng không đủ đáp ứng", "Thông Báo");
                return;
            }
            if (dt.Sua(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString(), int.Parse(txt_soluong.Text))==true)
            {
                MessageBox.Show("Thành Công", "Thông Báo");
                
            }
            else
            {
                MessageBox.Show("Thất Bại", "Thông Báo");
            }
            //load du lieu chi tiết hóa đơn theo khách
            dataGridViewChiTietHoaDon.DataSource = dt.LoadCTHoaDonTheoKhach();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dt.Xoa(cbbmahoadon.SelectedValue.ToString(), cbbMaHang.SelectedValue.ToString())==true)
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
                //load du lieu chi tiết hóa đơn theo khách
                dataGridViewChiTietHoaDon.DataSource = dt.LoadCTHoaDonTheoKhach();
            }
        }

        private void dataGridViewChiTietHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewChiTietHoaDon.CurrentRow != null)
            {
                cbbmahoadon.SelectedValue = dataGridViewChiTietHoaDon.CurrentRow.Cells[0].Value.ToString();
                cbbMaHang.SelectedValue = dataGridViewChiTietHoaDon.CurrentRow.Cells[1].Value.ToString();
                txt_soluong.Text = dataGridViewChiTietHoaDon.CurrentRow.Cells[2].Value.ToString();
                txt_dongia.Text = dataGridViewChiTietHoaDon.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //load du lieu chi tiết hóa đơn theo khách
            dataGridViewChiTietHoaDon.DataSource = dt.LoadCTHoaDonTheoKhach();
        }
    }
}
