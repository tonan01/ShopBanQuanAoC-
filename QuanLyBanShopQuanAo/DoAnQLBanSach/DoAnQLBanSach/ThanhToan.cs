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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        public static string TenDangNhap = "";
        XuLyThanhToan dt = new XuLyThanhToan();
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            //vo hieu hoa
            cbb_tenkhachhang.Enabled = false;
            //load combobox ten khach
            cbb_tenkhachhang.DataSource = dt.LoadTenKhachHang();
            cbb_tenkhachhang.DisplayMember = "TenKH";
            cbb_tenkhachhang.ValueMember = "MaKH";
            //load hoa don can thanh toan
            dataGridViewHoaDon.DataSource = dt.LoadDataHoaDonChoThanhToan();
            //load combobox ma hoa don
            cbb_mahoadon.DataSource = dt.LoadDataHoaDonChoThanhToan();
            cbb_mahoadon.DisplayMember = "MaHD";
            cbb_mahoadon.ValueMember = "MaHD";
        }

        private void dataGridViewHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHoaDon.CurrentRow != null)
            {
                cbb_mahoadon.SelectedValue = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
                cbb_tenkhachhang.SelectedValue = dataGridViewHoaDon.CurrentRow.Cells[3].Value.ToString();
                lbe_tongthanhtien.Text = dataGridViewHoaDon.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if(dt.KTQuyenAdmin()==true)//là admin
            {
                MessageBox.Show("Chỉ Có Nhân Viên Được Quyền thanh toán", "Thông Báo");
                return;
            }
            if(dt.ThanhToan(cbb_mahoadon.SelectedValue.ToString())==true)
            {
                MessageBox.Show("Thành Công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Thất Bại", "Thông Báo");
            }
            //load hoa don can thanh toan
            dataGridViewHoaDon.DataSource = dt.LoadDataHoaDonChoThanhToan();
            //load combobox ma hoa don
            cbb_mahoadon.DataSource = dt.LoadDataHoaDonChoThanhToan();
            cbb_mahoadon.DisplayMember = "MaHD";
            cbb_mahoadon.ValueMember = "MaHD";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //vo hieu hoa
            cbb_tenkhachhang.Enabled = false;
            //load combobox ten khach
            cbb_tenkhachhang.DataSource = dt.LoadTenKhachHang();
            cbb_tenkhachhang.DisplayMember = "TenKH";
            cbb_tenkhachhang.ValueMember = "MaKH";
            //load hoa don can thanh toan
            dataGridViewHoaDon.DataSource = dt.LoadDataHoaDonChoThanhToan();
            //load combobox ma hoa don
            cbb_mahoadon.DataSource = dt.LoadDataHoaDonChoThanhToan();
            cbb_mahoadon.DisplayMember = "MaHD";
            cbb_mahoadon.ValueMember = "MaHD";
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            //vo hieu hoa
            cbb_tenkhachhang.Enabled = false;
            //load combobox ten khach
            cbb_tenkhachhang.DataSource = dt.LoadTenKhachHang();
            cbb_tenkhachhang.DisplayMember = "TenKH";
            cbb_tenkhachhang.ValueMember = "MaKH";
            //load hoa don can thanh toan
            dataGridViewHoaDon.DataSource = dt.LoadDataHoaDonChoThanhToan();
            //load combobox ma hoa don
            cbb_mahoadon.DataSource = dt.LoadDataHoaDonChoThanhToan();
            cbb_mahoadon.DisplayMember = "MaHD";
            cbb_mahoadon.ValueMember = "MaHD";
        }
    }
}
