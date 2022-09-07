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
    public partial class HoaDonKhach : Form
    {
        public HoaDonKhach()
        {
            InitializeComponent();
        }
        XuLyHoaDonKhach dt = new XuLyHoaDonKhach();
        private void HoaDonKhach_Load(object sender, EventArgs e)
        {
            //load hoa don
            dataGridViewHoaDon.DataSource = dt.LoadDataHoaDon();
            //load combobox ma hoa don
            cbb_mahoadon.DataSource = dt.LoadDataHoaDon();
            cbb_mahoadon.DisplayMember = "MaHD";
            cbb_mahoadon.ValueMember = "MaHD";
            //hien thu  tong tien
            lbe_tongthanhtien.Text = "Tổng Thành Tiên: " + dt.HienThiTongTien().ToString();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn hủy hóa đơn này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dt.HuyHoaDon(cbb_mahoadon.SelectedValue.ToString()) == true)//thanh cong
                {
                    //hien thu  tong tien
                    lbe_tongthanhtien.Text = "Tổng Thành Tiên: " + dt.HienThiTongTien().ToString();
                    //load hoa don
                    dataGridViewHoaDon.DataSource = dt.LoadDataHoaDon();
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
                
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            //+Hiển thị thông báo xác nhận
            if (MessageBox.Show("Bạn có muốn đặt hàng các sản phẩm này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(dt.KTdathang(cbb_mahoadon.SelectedValue.ToString())==false)//đã đặt hàng
                {
                    MessageBox.Show("Mã hóa đơn đã được đăt hàng \nVui lòng đợi nhân viên đến thanh toán", "Thông báo");
                    return;
                }
                if (dt.Dat(cbb_mahoadon.SelectedValue.ToString()) == true)//thanh cong
                {
                    //load hoa don
                    dataGridViewHoaDon.DataSource = dt.LoadDataHoaDon();
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
                //hien thu lai tong tien
                lbe_tongthanhtien.Text = "Tổng Thành Tiên: " + dt.HienThiTongTien().ToString();
                

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHoaDon.CurrentRow != null)
            {
                cbb_mahoadon.SelectedValue = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //load hoa don
            dataGridViewHoaDon.DataSource = dt.LoadDataHoaDon();
            //hien thu  tong tien
            lbe_tongthanhtien.Text = "Tổng Thành Tiên: " + dt.HienThiTongTien().ToString();
        }
    }
}
